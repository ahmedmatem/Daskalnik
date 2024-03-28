using Core.Models.Topic;

namespace Core.Contracts
{
    public interface ITopicService
    {
        Task AddAsync(TopicFormServiceModel model);
    }
}
