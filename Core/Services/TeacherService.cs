using Core.Contracts;
using Core.Models.Teacher;
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

        public async Task ActivateAsync(Teacher teacher)
        {
            teacher.IsActivated = true;
            repository.Update(teacher);
            await repository.SaveChangesAsync<Teacher>();
        }

        public async Task<IEnumerable<TeacherDropdownViewModel>?>
            GetSchoolAdminCandidatesAsync(string schoolId)
        {
            return await repository
                .AllReadOnly<Teacher>()
                .Where(t => !t.IsActivated && t.SchoolId == schoolId)
                .Select(t => new TeacherDropdownViewModel()
                {
                    Id = t.Id,
                    Name = t.FullName
                })
                .ToListAsync();
        }

        public async Task<Teacher?> GetByIdAsync(string id)
        {
            return await repository.GetByIdAsync<Teacher>(id);
        }

        public async Task<int> GetTeachersCountAsync()
        {
            return await repository
                .All<Teacher>()
                .Where(t => !t.IsDeleted)
                .CountAsync();
        }

        public async Task<int> GetTeachersCountInSchoolAsync(string schoolId)
        {
            return await repository
                .All<Teacher>()
                .Where(t => t.SchoolId == schoolId && !t.IsDeleted)
                .CountAsync();
        }

        public async Task<IEnumerable<TeacherTableRowServiceModel>>
            GetAllTeachersInSchool(string schoolId, string schoolAdminId)
        {
            var schoolAdmin = await repository
                .GetByIdAsync<Teacher>(schoolAdminId);
            if (schoolAdmin != null && schoolAdmin.SchoolId == schoolId)
            {
                return await repository.AllReadOnly<Teacher>()
                .Where(t => t.SchoolId == schoolId)
                .Select(t => new TeacherTableRowServiceModel()
                {
                    SchoolId = schoolId,
                    TeacherId = t.Id,
                    FullName = t.FullName,
                    IsDeleted = t.IsDeleted
                })
                .OrderBy(m => m.FullName)
                .ToListAsync();
            }

            return Enumerable.Empty<TeacherTableRowServiceModel>();
        }

        public async Task<bool> DeleteAsync(
            string teacherId,
            string schoolId,
            string schoolAdminId)
        {
            var schoolAdmin = await repository.GetByIdAsync<Teacher>(schoolAdminId);

            if (schoolAdmin != null && schoolAdmin.SchoolId == schoolId)
            {
                var teacher = await repository.GetByIdAsync<Teacher>(teacherId);
                if (teacher != null && teacher.SchoolId == schoolId)
                {
                    teacher.IsDeleted = true;
                    repository.Update(teacher);
                    await repository.SaveChangesAsync<Teacher>();
                    return true;
                }
            }

            return false;
        }

        public async Task<bool> RestoreAsync(
            string teacherId,
            string schoolId,
            string schoolAdminId)
        {
            var schoolAdmin = await repository.GetByIdAsync<Teacher>(schoolAdminId);

            if (schoolAdmin != null && schoolAdmin.SchoolId == schoolId)
            {
                var teacher = await repository.GetByIdAsync<Teacher>(teacherId);
                if (teacher != null && teacher.SchoolId == schoolId)
                {
                    teacher.IsDeleted = false;
                    repository.Update(teacher);
                    await repository.SaveChangesAsync<Teacher>();
                    return true;
                }
            }

            return false;
        }
    }
}
