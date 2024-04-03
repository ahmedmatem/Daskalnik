using Core.Models.Resource;
using Infrastructure.Data.Models;

namespace Core.Contracts
{
    public interface IResourceService
    {
        Task AddAsync(ResourceFormServiceModel model);

        Task UpdateAsync(ResourceFormServiceModel model);

        Task<IEnumerable<ResourceServiceModel>> GetAllByCreator(string creatorId);

        IQueryable<Resource> GetAllByIds(IEnumerable<string> ids);

        Task<ResourceFormServiceModel?> GetByIdAsync(string id);
    }
}
