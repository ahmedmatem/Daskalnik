namespace Core.Contracts
{
    public interface IGroupService
    {
        Task<int> GetGroupsCountAsync();

        Task<int> GetGroupsCountInSchoolAsync(string schoolId);
    }
}
