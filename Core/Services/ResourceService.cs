using Core.Contracts;
using Core.Models.Resource;
using Infrastructure.Data.DataRepository;

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

        public Task AddByFileAsync(ResourceFormServiceModel model)
        {
            model.ResourceFile
        }

        public Task AddByLinkAsync(ResourceFormServiceModel model)
        {
            throw new NotImplementedException();
        }
    }
}
