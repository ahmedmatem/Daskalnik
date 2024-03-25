using Core.Contracts;
using Infrastructure.Data.DataRepository;
using Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Core.Services
{
    public class StudentService : IStudentService
    {
        private readonly IRepository repository;

        public StudentService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<int> GetStudentsCountAsync()
        {
            return await repository
                .All<Student>()
                .Where(s => !s.IsDeleted)
                .CountAsync();
        }

        public async Task<int> GetStudentsCountInSchoolAsync(string schoolId)
        {
            return await repository
                .All<Student>()
                .Where(s => s.SchoolId == schoolId && !s.IsDeleted)
                .CountAsync();
        }
    }
}
