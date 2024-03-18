using Core.Contracts;
using Infrastructure.Data.DataRepository;
using Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Core.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly IRepository repository;

        public TeacherService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<int> GetTeachersCountAsync()
        {
            return await repository
                .All<Teacher>()
                .Where(t => !t.IsDeleted)
                .CountAsync();
        }
    }
}
