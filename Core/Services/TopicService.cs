using Core.Contracts;
using Core.Models.Common;
using Core.Models.GroupTopic;
using Core.Models.Resource;
using Core.Models.Topic;
using Infrastructure.Data.DataRepository;
using Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Core.Services
{
    public class TopicService : ITopicService
    {
        private readonly IRepository repository;
        private readonly IResourceService resourceService;

        public TopicService(
            IRepository _repository,
            IResourceService _resourceService)
        {
            repository = _repository;
            resourceService = _resourceService;
        }

        public async Task AddAsync(TopicFormServiceModel model)
        {
            var topicResources = await resourceService
                .GetAllByIds(model.SelectedResources)
                .Select(sr => new TopicResource()
                {
                    ResourceId = sr.Id,
                    TopicId = model.Id
                })
                .ToListAsync();

            Topic topic = new Topic()
            {
                Name = model.Name,
                Description = model.Description ?? string.Empty,
                Contents = model.Contents,
                CreatorId = model.CreatorId,
                Resources = topicResources
            };

            await repository.AddAsync(topic);
            await repository.SaveChangesAsync<Topic>();
        }

        public async Task<GroupTopicSelectFormServiceModel>
            GetAllCreatorTopicsExcludedFromGroupAsync(string groupId, string creatorId)
        {
            var topicsByCreator = await repository.All<Topic>()
                .Where(t => !t.IsDeleted && t.CreatorId == creatorId)
                .Select(t => new CheckBoxModel()
                {
                    Key = t.Id,
                    Value = t.Name
                })
                .ToListAsync();

            var group = await repository.GetByIdAsync<Group>(groupId);

            IEnumerable<CheckBoxModel> topicsListToAdd = new List<CheckBoxModel>();
            if (group != null)
            {
                // Excluding all topics that are already in the group
                topicsListToAdd = topicsByCreator
                    .ExceptBy(group.Topics.Select(x => x.Id), x => x.Key);
            }

            return new GroupTopicSelectFormServiceModel()
            {
                GroupId = groupId,
                GroupName = group?.Name ?? string.Empty,
                TopicsListToAdd = topicsByCreator
            };
        }

        public async Task<IEnumerable<TopicListItemServiceModel>>
            GetAllTopicsByCreatorAsync(string creatorId)
        {
            return await repository.AllReadOnly<Topic>()
                .Where(t => t.CreatorId == creatorId && !t.IsDeleted)
                .Select(t => new TopicListItemServiceModel
                {
                    Id = t.Id,
                    Name = t.Name,
                    Description = t.Description,
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
                    CreatorId = t.CreatorId,
                    AddedResources = t.Resources
                    .Select(r => new ResourceServiceModel()
                    {
                        Id = r.ResourceId,
                        Link = r.Resource.Link,
                        TextToDisplay = r.Resource.TextToDisplay,
                        IconRef = r.Resource.IconRef,
                        CreatorId = r.Resource.CreatorId
                    }),
                    CreatorAllResources = resourceService.GetAllByCreator(t.CreatorId)
                    .AsEnumerable(),
                    SelectedResources = t.Resources.Select(r => r.ResourceId),
                })
                .FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(TopicFormServiceModel model)
        {
            var topic = await repository.GetByIdAsync<Topic>(model.Id);
            var newTopicResources = await resourceService
                .GetAllByIds(model.SelectedResources)
                .Select(sr => new TopicResource()
                {
                    ResourceId = sr.Id,
                    TopicId = model.Id
                })
                .ToListAsync();

            if (topic != null)
            {
                topic.Name = model.Name;
                topic.Description = model.Description ?? string.Empty;
                topic.Contents = model.Contents;
                topic.Resources.AddRange(newTopicResources);

                repository.Update(topic);
                await repository.SaveChangesAsync<Topic>();
            }
        }
    }
}
