using Core.Models.Teachers;
using Infrastructure.Data.Models;

namespace Core.Contracts
{
    public interface ITeacherService
    {
        Task<int> GetTeachersCountAsync();

        Task<int> GetTeachersCountInSchoolAsync(string schoolId);

        Task<IEnumerable<TeacherDropdownViewModel>?> GetSchoolAdminCandidatesAsync(string schoolId);

        Task<Teacher?> GetByIdAsync(string id);

        Task ActivateAsync(Teacher teacher);
    }
}
