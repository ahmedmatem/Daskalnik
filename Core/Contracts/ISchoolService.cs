using Core.Models.Schools;
using Infrastructure.Data.Models;

namespace Core.Contracts
{
    public interface ISchoolService
    {
        Task<int> GetSchoolsCountAsync();

        Task<IEnumerable<SchoolViewModel>> GetAllAsync();

        Task<IEnumerable<SchoolViewModel>> GetAllBlockedAsync();

        Task AddAsync(SchoolFormViewModel model);

        Task<SchoolViewModel?> GetByIdAsync(string id);

        Task<bool> SchoolExistsAsync(string id);

        Task<bool> TryAddSchoolAdminAsync(string schoolId, string teacherId);

        Task UpdateAsync(SchoolViewModel model);

        Task BlockAsync(string id);

        Task UnblockAsync(string id);
    }
}
