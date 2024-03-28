using Core.Contracts;
using Core.Models.Topic;
using Infrastructure.Data.DataRepository;
using Infrastructure.Data.Models;

namespace Core.Services
{
    public class TopicService : ITopicService
    {
        private readonly IRepository repository;

        public TopicService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task AddAsync(TopicFormServiceModel model)
        {
            //Topic topic = new Topic()
            //{
            //    Name = model.Name,
            //    Description = model.Description,
            //    Contents = model.Contents
            //};

            //await repository.AddAsync(model);
            //await repository.SaveChangesAsync<Topic>();
        }
    }
}
