﻿namespace Core.Contracts
{
    using Core.Models.Group;

    using Infrastructure.Data.Models;

    public interface IGroupService
    {
        Task<int> GetGroupsCountAsync();

        Task<int> GetGroupsCountInSchoolAsync(string schoolId);

        Task AddAsync(GroupFormServiceModel model);

        Task<IEnumerable<GroupCardViewModel>> GetAllTeacherGroups(string teacherId);

        Task<StudentGroupServiceModel?> GetStudentGroup(string groupId);

        IQueryable<Group> GetAllStudentGroups(string studentId);

        Task<IEnumerable<GroupTableRowServiceModel>> 
            GetAllGroupsInSchool(string schoolId, string schoolAdminId);

        Task<GroupServiceModel?> GetByIdAsync(string groupId);

        Task<Group?> GetGroupByIdAsync(string groupId);

        Task AssignTopicsToGroupAsync(string groupId, IEnumerable<string> topicIds);

        Task<int> AssignExamsToGroupAsync(IEnumerable<string> examIds, string groupId);

        Task AddStudentsInGroupAsync(string groupId, IEnumerable<string> studentIds);

        Task<bool> RemoveTopicFromGroupAsync(string topicId, string groupId);

        Task<bool> RemoveStudentFromGroupAsync(string studentId, string groupId);

        Task<bool> StopBySchoolAdminAsync(
            string groupId, string schoolId, string schoolAdminId);

        Task<bool> StartBySchoolAdminAsync(
            string groupId, string schoolId, string schoolAdminId);
    }
}
