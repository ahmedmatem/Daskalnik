using Core.Contracts;
using Core.Models.Group;
using Core.Models.GroupTopic;
using Infrastructure.Data.DataRepository;
using Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Core.Services
{
    public class GroupService : IGroupService
    {
        private readonly IRepository repository;
        private readonly ITopicService topicService;

        public GroupService(
            IRepository _repository,
            ITopicService _topicService)
        {
            repository = _repository;
            topicService = _topicService;
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

        public async Task<GroupServiceModel?> GetByIdAsync(string id)
        {
            return await repository.All<Group>()
                .Where(g => !g.IsDeleted && g.Id == id)
                .Select(g => new GroupServiceModel()
                {
                    Id = id,
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
