using Core.Models.Topic;
using Infrastructure.Data.Models;

namespace Core.Contracts
{
    public interface ITopicService
    {
        Task<TopicFormServiceModel?> GetByIdAsync(string id);

        Task<IEnumerable<TopicListItemServiceModel>> GetAllTopicsByCreatorAsync(string creatorId);

        Task AddAsync(TopicFormServiceModel model);

        Task UpdateAsync(TopicFormServiceModel model);
    }
}
