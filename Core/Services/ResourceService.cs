using Core.Contracts;
using Core.Models.Resource;
using Infrastructure.Data.DataRepository;
using Infrastructure.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using IResourceService = Core.Contracts.IResourceService;

namespace Core.Services
{
    public class ResourceService : IResourceService
    {
        private readonly IRepository repository;
        private readonly IAzureBlobService azureBlobService;

        public ResourceService(
            IRepository _repository,
            IAzureBlobService _azureBlobService)
        {
            repository = _repository;
            azureBlobService = _azureBlobService;
        }

        public async Task AddAsync(ResourceFormServiceModel model)
        {
            if (model.ResourceFile != null)
            {
                var blobName = GetRandomBlobName(model.ResourceFile);
                model.Link = azureBlobService.BlobContainerURL + blobName;

                await azureBlobService.UploadFileAsync(model.ResourceFile, blobName);                
            }

            Resource newResource = new Resource()
            {
                Link = model.Link,
                IconRef = model.IconRef,
                CreatorId = model.CreatorId,
                TextToDisplay = model.TextToDisplay
            };

            await repository.AddAsync(newResource);
            await repository.SaveChangesAsync<Resource>();
        }

        public IQueryable<ResourceServiceModel> GetAllByCreator(string creatorId)
        {
            return repository.AllReadOnly<Resource>()
                .Where(r => r.CreatorId == creatorId && !r.IsDeleted)
                .Select(r => new ResourceServiceModel()
                {
                    Id = r.Id,
                    Link = r.Link,
                    TextToDisplay = r.TextToDisplay,
                    IconRef = r.IconRef,
                    CreatorId = r.CreatorId,
                })
                .OrderBy(r => r.TextToDisplay);
        }

        public IQueryable<Resource> GetAllByIds(IEnumerable<string> ids)
        {
            return repository
                .All<Resource>()
                .Where(r => ids.Contains(r.Id) && !r.IsDeleted);
        }

        public async Task<ResourceFormServiceModel?> GetByIdAsync(string id)
        {
            var resource = await repository.GetByIdAsync<Resource>(id);

            if(resource != null)
            {
                return new ResourceFormServiceModel()
                {
                    Id = resource.Id,
                    Link = resource.Link,
                    TextToDisplay = resource.TextToDisplay,
                    IconRef = resource.IconRef,
                    CreatorId = resource.CreatorId,
                };
            }

            return null;
        }

        public async Task UpdateAsync(ResourceFormServiceModel model)
        {
            var oldResource = await repository.GetByIdAsync<Resource>(model.Id);
            if (oldResource != null)
            {
                oldResource.TextToDisplay = model.TextToDisplay;
                if (oldResource.Link.Contains(azureBlobService.BlobContainerURL) == false)
                {
                    // Link is not a blob.
                    oldResource.Link = model.Link;
                }
                oldResource.IconRef = model.IconRef;

                repository.Update(oldResource);
                await repository.SaveChangesAsync<Resource>();
            }
        }

        private string GetRandomBlobName(IFormFile file)
        {
            return Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
        }
    }
}
