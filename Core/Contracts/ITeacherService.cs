using Core.Models.ApplicationUser;
using Core.Models.Teacher;
using Infrastructure.Data.Models;

namespace Core.Contracts
{
    public interface ITeacherService
    {
        Task<int> GetTeachersCountAsync();

        Task CreateAsync(RegisterFormModel model);

        Task<int> GetTeachersCountInSchoolAsync(string schoolId);

        Task<IEnumerable<TeacherDropdownViewModel>?> 
            GetSchoolAdminCandidatesAsync(string schoolId);

        Task<IEnumerable<TeacherTableRowServiceModel>> GetAllTeachersInSchool(
            string schoolId, string schoolAdminId);

        Task<Teacher?> GetByIdAsync(string id);

        Task ActivateAsync(Teacher teacher);

        Task<bool> DeleteAsync(
            string teacherId, string schoolId, string schoolAdminId);

        Task<bool> RestoreAsync(
            string teacherId, string schoolId, string schoolAdminId);
    }
}
