using Core.Contracts;
using Core.Models.Admin.Schools;
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

        public async Task AddAsync(SchoolFormViewModel model)
        {
            School school = new School()
            {
                Name = model.Name,
                Type = model.Type,
                City = model.City
            };

            repository.Add(school);
            await repository.SaveChangesAsync<School>();            
        }

        public async Task<IEnumerable<SchoolViewModel>> GetAllAsync()
        {
            return await repository
                .AllReadOnly<School>()
                .Where(s => !s.IsDeleted)
                .Select(s => new SchoolViewModel()
                {
                    Id = s.Id,
                    Name = s.Name,
                    Type = s.Type,
                    City = s.City,
                })
                .ToListAsync();
        }

        public async Task<int> GetSchoolsCountAsync()
        {
            return await repository
                .All<School>()
                .Where(s => !s.IsDeleted)
                .CountAsync();
        }
    }
}
