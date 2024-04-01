using Core.Models.Resource;

namespace Core.Contracts
{
    public interface IResourceService
    {
        Task AddByLinkAsync(ResourceFormServiceModel model);

        Task AddByFileAsync(ResourceFormServiceModel model);
    }
}
