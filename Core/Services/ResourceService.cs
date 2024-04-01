using Core.Contracts;
using Core.Models.Resource;
using Infrastructure.Data.DataRepository;
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

        public async Task AddByFileAsync(ResourceFormServiceModel model)
        {
            if (model.ResourceFile != null)
            {
                var blobName = GetRandomBlobName(model.ResourceFile);
                await azureBlobService.UploadFileAsync(model.ResourceFile, blobName);


            }
        }

        public Task AddByLinkAsync(ResourceFormServiceModel model)
        {
            throw new NotImplementedException();
        }

        private string GetRandomBlobName(IFormFile file)
        {
            return Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
        }
    }
}
