using Core.Models.School;
using Infrastructure.Data.Models;

namespace Core.Contracts
{
    public interface ISchoolService
    {
        Task<int> GetSchoolsCountAsync();

        Task<IEnumerable<SchoolServiceModel>> GetAllAsync();

        Task<IEnumerable<SchoolServiceModel>> GetAllBlockedAsync();

        Task AddAsync(SchoolFormViewModel model);

        Task<SchoolServiceModel?> GetByIdAsync(string id);

        Task<bool> SchoolExistsAsync(string id);

        Task<bool> TryAddSchoolAdminAsync(string schoolId, string teacherId);

        Task UpdateAsync(SchoolServiceModel model);

        Task BlockAsync(string id);

        Task UnblockAsync(string id);
    }
}
