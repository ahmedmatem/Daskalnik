using Core.Contracts;
using Core.Models.Group;
using Core.Models.GroupTopic;
using Core.Models.Resource;
using Core.Models.Topic;
using Infrastructure.Data.DataRepository;
using Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Core.Services
{
    public class GroupService : IGroupService
    {
        private readonly IRepository repository;
        private readonly ITopicService topicService;
        private readonly IResourceService resourceService;
        private readonly ITopicResourceService topicResourceService;

        public GroupService(
            IRepository _repository,
            ITopicService _topicService,
            IResourceService _resourceService,
            ITopicResourceService _topicResourceService)
        {
            repository = _repository;
            topicService = _topicService;
            resourceService = _resourceService;
            topicResourceService = _topicResourceService;
        }

        public async Task AddAsync(GroupFormServiceModel model)
        {
            Group group = new Group()
            {
                Name = model.Name,
                ShortName = model.ShortName,
                Description = model.Description,
                IconUrl = model.IconUrl,
                TeacherId = model.TeacherId,
                SchoolId = model.SchoolId,
            };

            await repository.AddAsync(group);
            await repository.SaveChangesAsync<Group>();
        }

        public async Task AddTopicsInGroupAsync(
            string groupId, IEnumerable<string> topicIds)
        {
            IEnumerable<GroupTopic> groupTopics = topicIds
                .Select(tId => new GroupTopic
                {
                    GroupId = groupId,
                    TopicId = tId
                });

            await repository.AddRangeAsync(groupTopics);
            await repository.SaveChangesAsync<GroupTopic>();
        }

        public async Task<IEnumerable<GroupCardViewModel>> GetAllTeacherGroups(string teacherId)
        {
            return await repository
                .All<Group>()
                .Where(g => !g.IsDeleted && g.TeacherId == teacherId)
                .OrderBy(g => g.Name)
                .Select(g => new GroupCardViewModel()
                {
                    Id = g.Id,
                    ShortName = g.ShortName,
                    IconUrl = g.IconUrl,
                })
                .ToListAsync();
        }

        public async Task<GroupServiceModel?> GetByIdAsync(string groupId)
        {
            var topicResources = repository.All<TopicResource>();

            return await repository.All<Group>()
                .Where(g => !g.IsDeleted && g.Id == groupId)
                .Select(g => new GroupServiceModel()
                {
                    Id = g.Id,
                    ShortName = g.ShortName,
                    Name = g.Name,
                    Description = g.Description,
                    IconUrl = g.IconUrl,
                    SchoolId = g.SchoolId,
                    TeacherId = g.TeacherId,
                    GroupTopics = new GroupTopicsModel()
                    {
                        GroupId = g.Id,
                        Topics = g.Topics
                        .Where(t => !t.IsDeleted)
                        .Select(t => new TopicListItemInGroupServiceModel()
                        {
                            GroupId = g.Id,
                            Contents = t.Contents,
                            CreatorId = t.CreatorId,
                            Resources = repository.All<Resource>()
                            .Where(r => r.CreatorId == t.CreatorId && !r.IsDeleted)
                            .Join(repository.All<TopicResource>(), ar => ar.Id, atr => atr.ResourceId,
                            (ar, atr) => new
                            {
                                AllResources = ar,
                                AllTopoicResources = atr
                            })
                            .Where(x => x.AllTopoicResources.TopicId == t.Id)
                            .Select(x => new ResourceServiceModel()
                            {
                                Id = x.AllResources.Id,
                                Link = x.AllResources.Link,
                                TextToDisplay = x.AllResources.TextToDisplay,
                                IconRef = x.AllResources.IconRef,
                                CreatorId = t.CreatorId
                            })
                        })
                    }
                })
                .FirstOrDefaultAsync();
        }

        public async Task<int> GetGroupsCountAsync()
        {
            return await repository
                .All<Group>()
                .Where(g => !g.IsDeleted)
                .CountAsync();
        }

        public async Task<int> GetGroupsCountInSchoolAsync(string schoolId)
        {
            return await repository
                .All<Group>()
                .Where(g => g.SchoolId == schoolId && !g.IsDeleted)
                .CountAsync();

        }
    }
}
