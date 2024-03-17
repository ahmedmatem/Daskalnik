using Core.Contracts;
using Infrastructure.Data.DataRepository;
using Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Core.Services
{
    public class SchoolService : ISchoolService
    {
        private readonly IRepository repository;

        public SchoolService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<int> GetSchoolsCountAsync()
        {
            return await repository.All<School>()
                .Where(s => !s.IsDeleted)
                .CountAsync();
        }
    }
}
