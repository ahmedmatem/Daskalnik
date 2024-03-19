using Core.Models.Admin.Schools;

namespace Core.Contracts
{
    public interface ISchoolService
    {
        Task<int> GetSchoolsCountAsync();

        Task<IEnumerable<SchoolViewModel>> GetAllAsync();

        Task AddAsync(SchoolFormViewModel model);
    }
}
