using Core.Models.Group;

namespace Core.Contracts
{
    public interface IGroupService
    {
        Task<int> GetGroupsCountAsync();

        Task<int> GetGroupsCountInSchoolAsync(string schoolId);

        Task AddAsync(GroupFormViewModel model);
    }
}
