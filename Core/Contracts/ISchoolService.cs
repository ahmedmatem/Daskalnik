using Core.Models.Admin.Schools;
using Infrastructure.Data.Models;

namespace Core.Contracts
{
    public interface ISchoolService
    {
        Task<int> GetSchoolsCountAsync();

        Task<IEnumerable<SchoolViewModel>> GetAllAsync();

        Task AddAsync(SchoolFormViewModel model);

        Task<SchoolViewModel?> GetByIdAsync(string id);

        Task<bool> SchoolExistsAsync(string id);

        Task<bool> TryAddSchoolAdminAsync(string schoolId, string teacherId);

        Task UpdateAsync(SchoolViewModel model);
    }
}
