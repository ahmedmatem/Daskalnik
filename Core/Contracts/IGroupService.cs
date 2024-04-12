using Core.Models.Group;
using Core.Models.GroupTopic;

namespace Core.Contracts
{
    public interface IGroupService
    {
        Task<int> GetGroupsCountAsync();

        Task<int> GetGroupsCountInSchoolAsync(string schoolId);

        Task AddAsync(GroupFormServiceModel model);

        Task<IEnumerable<GroupCardViewModel>> GetAllTeacherGroups(string teacherId);

        Task<IEnumerable<GroupTableRowServiceModel>> 
            GetAllGroupsInSchool(string schoolId, string schoolAdminId);

        Task<GroupServiceModel?> GetByIdAsync(string groupId);

        Task AddTopicsInGroupAsync(string groupId, IEnumerable<string> topicIds);

        Task AddStudentsInGroupAsync(string groupId, IEnumerable<string> studentIds);

        Task<bool> RemoveTopicFromGroupAsync(string topicId, string groupId);

        Task<bool> RemoveStudentFromGroupAsync(string studentId, string groupId);

        Task<bool> StopBySchoolAdminAsync(
            string groupId, string schoolId, string schoolAdminId);

        Task<bool> StartBySchoolAdminAsync(
            string groupId, string schoolId, string schoolAdminId);
    }
}
