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

        /// <summary>
        /// Check if a resource is assigned in a topic or exam.
        /// </summary>
        /// <param name="resId"></param>
        /// <returns>true - if resource is assigned, false otherwise.</returns>
        Task<bool> IsAssignedAsync(string resourceId);

        Task DeleteAsync(string resourceId);
    }
}
