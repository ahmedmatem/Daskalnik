using Core.Contracts;
using Core.Models.Resource;
using Infrastructure.Data.DataRepository;
using Infrastructure.Data.Models;
using Microsoft.AspNetCore.Http;

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

        private string GetRandomBlobName(IFormFile file)
        {
            return Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
        }
    }
}
