using Core.Models.GroupStudent;

namespace Core.Contracts
{
    public interface IStudentService
    {
        Task<int> GetStudentsCountAsync();

        Task<int> GetStudentsCountInSchoolAsync(string schoolId);

        Task<GroupStudentSelectFormServiceModel> GettAllStudentsInSchoolExcludedFromGroupAsync(
            string groupId, string groupCreatorId);
    }
}
