using Core.Contracts;
using Core.Models.Resource;
using Infrastructure.Data.DataRepository;
using Infrastructure.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

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

        public async Task<IEnumerable<ResourceServiceModel>> GetAllREsourcesByCreator(string creatorId)
        {
            return await repository.AllReadOnly<Resource>()
                .Where(r => r.CreatorId == creatorId && !r.IsDeleted)
                .Select(r => new ResourceServiceModel()
                {
                    Id = r.Id,
                    Link = r.Link,
                    TextToDisplay=r.TextToDisplay,
                    IconRef=r.IconRef,
                    CreatorId =r.CreatorId,
                })
                .OrderBy(r => r.TextToDisplay)
                .ToListAsync();
        }

        private string GetRandomBlobName(IFormFile file)
        {
            return Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
        }
    }
}
