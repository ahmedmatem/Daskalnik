namespace Core.Contracts
{
    public interface ITopicResourceService
    {
        Task DeleteAsync(string topicId, string resourceId);
    }
}
