using Core.Models.ApplicationUser;
using Core.Models.GroupStudent;
using Core.Models.Student;

namespace Core.Contracts
{
    public interface IStudentService
    {
        Task<int> GetStudentsCountAsync();

        Task CreateAsync(RegisterFormModel model);

        Task<int> GetStudentsCountInSchoolAsync(string schoolId);

        Task<IEnumerable<StudentTableRowServiceModel>> GetAllStudentsInSchool(
            string schoolId, string schoolAdminId);

        Task<GroupStudentSelectFormServiceModel> GettAllStudentsInSchoolExcludedFromGroupAsync(
            string groupId, string groupCreatorId);

        Task<bool> DeleteAsync(
            string studentId, string schoolId, string schoolAdminId);

        Task<bool> RestoreAsync(
            string studentId, string schoolId, string schoolAdminId);
    }
}
