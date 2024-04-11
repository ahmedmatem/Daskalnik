using Core.Contracts;
using Core.Models.Group;
using Core.Models.GroupTopic;
using Core.Models.Resource;
using Core.Models.Student;
using Core.Models.Topic;
using Infrastructure.Data.DataRepository;
using Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Core.Services
{
    public class GroupService : IGroupService
    {
        private readonly ILogger<GroupService> logger;
        private readonly IRepository repository;
        private readonly ITopicService topicService;
        private readonly IResourceService resourceService;
        private readonly ITopicResourceService topicResourceService;

        public GroupService(
            ILogger<GroupService> _logger,
            IRepository _repository,
            ITopicService _topicService,
            IResourceService _resourceService,
            ITopicResourceService _topicResourceService)
        {
            logger = _logger;
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
            string groupId,
            IEnumerable<string> topicsIds)
        {
            var group = await repository.GetByIdAsync<Group>(groupId);

            ICollection<Topic> topics = new List<Topic>();
            foreach (var id in topicsIds)
            {
                var topic = await repository.GetByIdAsync<Topic>(id);
                if (topic != null)
                {
                    topics.Add(topic);
                }
            }

            if (group != null)
            {
                group.Topics.AddRange(topics);

                repository.Update(group);
                await repository.SaveChangesAsync<Group>();
            }
        }

        public async Task<IEnumerable<GroupCardViewModel>> GetAllTeacherGroups(
            string teacherId)
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
                            TopicId = t.Id,
                            Description = t.Description,
                            Name = t.Name,
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
                    },
                    GroupStudents = new GroupStudentsModel
                    {
                        GroupId = groupId,
                        Students = repository.All<Student>()
                        .Select(identityStudent => identityStudent.Id)
                        .Join(
                            repository.All<GroupStudent>(),
                            identityStudentId => identityStudentId,
                            groupStudent => groupStudent.StudentId,
                            (identityStudentId, groupStudent) => new GroupStudent
                            {
                                StudentId = identityStudentId,
                                GroupId = groupStudent.GroupId,
                            })
                        .Join(
                            repository.All<Student>().Include(s => s.School),
                            gs => gs.StudentId, student => student.Id,
                            (gs, student) => student)
                        .Where(s => s.IsActivated && !s.IsDeleted)
                        .OrderBy(s => s.FullName)
                        .Select(s => new StudentListItemInGroupServiceModel()
                        {
                            StudentId = s.Id,
                            FullName = s.FullName,
                            School = s.School
                        })
                        .ToList()
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

        public async Task<bool> RemoveStudentFromGroupAsync(string studentId, string groupId)
        {
            var studentInGroup = await repository.GetByIdAsync<GroupStudent>(
                new string[] { groupId, studentId });

            if(studentInGroup != null)
            {
                repository.Delete<GroupStudent>(studentInGroup);
                await repository.SaveChangesAsync<GroupStudent>();
                return true;
            }

            logger.LogWarning("Student with id: {studentId} was not found in Group with id: {groupId}.", studentId, groupId);

            return false;
        }

        public async Task<bool> RemoveTopicFromGroupAsync(string topicId, string groupId)
        {
            var group = await repository.All<Group>()
                .Where(g => g.Id == groupId)
                .Include(g => g.Topics)
                .FirstOrDefaultAsync();

            if (group != null)
            {
                var removedTopicsNumber = group.Topics.RemoveAll(t => t.Id == topicId);
                if (removedTopicsNumber > 0)
                {
                    repository.Update(group);
                    await repository.SaveChangesAsync<Group>();

                    return true;
                }
            }

            logger.LogWarning("Group with id: {groupId} was not found.", groupId);

            return false;
        }
    }
}
