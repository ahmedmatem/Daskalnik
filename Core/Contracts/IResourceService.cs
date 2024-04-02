using Core.Models.Resource;

namespace Core.Contracts
{
    public interface IResourceService
    {
        Task AddAsync(ResourceFormServiceModel model);

        Task UpdateAsync(ResourceFormServiceModel model);

        Task<IEnumerable<ResourceServiceModel>> GetAllByCreator(string creatorId);

        Task<ResourceFormServiceModel?> GetByIdAsync(string id);
    }
}
