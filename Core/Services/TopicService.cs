using Core.Contracts;
using Core.Models.Topic;
using Infrastructure.Data.DataRepository;
using Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

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
            Topic topic = new Topic()
            {
                Name = model.Name,
                Description = model.Description ?? string.Empty,
                Contents = model.Contents,
                CreatorId = model.CreatorId
            };

            await repository.AddAsync(topic);
            await repository.SaveChangesAsync<Topic>();
        }

        public async Task<IEnumerable<TopicListItemServiceModel>> GetAllTopicsByCreatorAsync(string creatorId)
        {
            return await repository.All<Topic>()
                .Where(t => t.CreatorId == creatorId && !t.IsDeleted)
                .Select(t => new TopicListItemServiceModel
                {
                    Id = t.Id,
                    Name = t.Name,
                    Description= t.Description,
                })
                .OrderBy(tl => tl.Name)
                .ToListAsync();
        }

        public async Task<TopicFormServiceModel?> GetByIdAsync(string id)
        {
            return await repository.All<Topic>()
                .Where(t => t.Id == id && !t.IsDeleted)
                .Select(t => new TopicFormServiceModel()
                {
                    Id = id,
                    Name = t.Name,
                    Description = t.Description,
                    Contents = t.Contents,
                    CreatorId = t.CreatorId
                })
                .FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(TopicFormServiceModel model)
        {
            var topic = await repository.GetByIdAsync<Topic>(model.Id);

            if (topic != null)
            {
                topic.Name = model.Name;
                topic.Description = model.Description ?? string.Empty;
                topic.Contents = model.Contents;

                repository.Update(topic);
                await repository.SaveChangesAsync<Topic>();
            }            
        }
    }
}
