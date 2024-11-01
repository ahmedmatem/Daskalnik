using Core.Models.Resource;
using Infrastructure.Data.Models;

namespace Core.Contracts
{
    public interface IResourceService
    {
        Task AddAsync(ResourceFormServiceModel model);

        Task UpdateAsync(ResourceFormServiceModel model);

        IQueryable<ResourceServiceModel> GetAllByCreator(string creatorId);

        IQueryable<ResourceServiceModel> GettAllExamsByCreator(string creatorId);

        IQueryable<ResourceServiceModel> GettAllTopicsByCreator(string creatorId);

        IQueryable<Resource> GetAllByIds(IEnumerable<string> ids);

        Task<ResourceFormServiceModel?> GetByIdAsync(string id);
    }
}
