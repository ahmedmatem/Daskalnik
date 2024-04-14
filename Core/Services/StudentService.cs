using Core.Contracts;
using Core.Models.ApplicationUser;
using Core.Models.Common;
using Core.Models.Group;
using Core.Models.GroupStudent;
using Core.Models.Student;
using Infrastructure.Data.DataRepository;
using Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Core.Services
{
    public class StudentService : IStudentService
    {
        private readonly IRepository repository;
        private readonly IGroupService groupService;

        public StudentService(
            IRepository _repository,
            IGroupService _groupService)
        {
            repository = _repository;
            groupService = _groupService;
        }

        public async Task<IEnumerable<StudentTableRowServiceModel>> GetAllStudentsInSchool(string schoolId, string schoolAdminId)
        {
            var schoolAdmin = await repository.GetByIdAsync<Teacher>(schoolAdminId);
            if (schoolAdmin != null && schoolAdmin.SchoolId == schoolId)
            {
                return await repository.AllReadOnly<Student>()
                .Where(s => s.SchoolId == schoolId)
                .OrderBy(s => s.FullName)
                .Select(s => new StudentTableRowServiceModel
                {
                    SchoolId = schoolId,
                    StudentId = s.Id,
                    FullName = s.FullName,
                    IsDeleted = s.IsDeleted
                })
                .ToListAsync();
            }

            return Enumerable.Empty<StudentTableRowServiceModel>();
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

        public async Task<GroupStudentSelectFormServiceModel> GettAllStudentsInSchoolExcludedFromGroupAsync(string groupId, string groupCreatorId)
        {
            IEnumerable<CheckBoxModel> studentsToAddInGroup = new List<CheckBoxModel>();
            Group? group = null;

            Teacher? groupCreator = await repository.GetByIdAsync<Teacher>(groupCreatorId);
            if (groupCreator != null)
            {
                string schoolId = groupCreator.SchoolId;

                group = await repository.AllReadOnly<Group>()
                    .Where(g => g.Id == groupId)
                    .FirstOrDefaultAsync();

                var studentsInGroupIds = repository
                    .AllReadonly<GroupStudent>(gs => gs.GroupId == groupId)
                    .Select(gs => gs.StudentId)
                    .AsEnumerable();

                studentsToAddInGroup = repository.AllReadOnly<Student>()
                    .Where(s => s.SchoolId == schoolId)
                    .AsEnumerable()
                    .ExceptBy(studentsInGroupIds, s => s.Id)
                    .Select(s => new CheckBoxModel()
                    {
                        Key = s.Id,
                        Value = s.FullName
                    })
                    .AsEnumerable();
            }

            return new GroupStudentSelectFormServiceModel()
            {
                GroupId = groupId,
                GroupName = group?.Name ?? string.Empty,
                StudentsListToAdd = studentsToAddInGroup.ToList(),
            };
        }

        public async Task<bool> DeleteAsync(
            string studentId,
            string schoolId,
            string schoolAdminId)
        {
            var schoolAdmin = await repository.GetByIdAsync<Teacher>(schoolAdminId);

            if (schoolAdmin != null && schoolAdmin.SchoolId == schoolId)
            {
                var student = await repository.GetByIdAsync<Student>(studentId);
                if (student != null && student.SchoolId == schoolId)
                {
                    student.IsDeleted = true;
                    repository.Update(student);
                    await repository.SaveChangesAsync<Student>();
                    return true;
                }
            }

            return false;
        }

        public async Task<bool> RestoreAsync(
            string studentId,
            string schoolId,
            string schoolAdminId)
        {
            var schoolAdmin = await repository.GetByIdAsync<Teacher>(schoolAdminId);

            if (schoolAdmin != null && schoolAdmin.SchoolId == schoolId)
            {
                var student = await repository.GetByIdAsync<Student>(studentId);
                if (student != null && student.SchoolId == schoolId)
                {
                    student.IsDeleted = false;
                    repository.Update(student);
                    await repository.SaveChangesAsync<Student>();
                    return true;
                }
            }

            return false;
        }

        public async Task CreateAsync(RegisterFormModel model)
        {
            Student student = new Student()
            {
                Id = model.Id,
                FullName = model.FullName,
                SchoolId = model.SchoolId
            };

            await repository.AddAsync(student);
            await repository.SaveChangesAsync<Student>();
        }

        public async Task<IEnumerable<GroupCardViewModel>> GetAllStudentGroups(string studentId)
        {
            return await groupService.GetAllStudentGroups(studentId)
                .Select(g => new GroupCardViewModel
                {
                    Id = g.Id,
                    IconUrl = g.IconUrl,
                    ShortName = g.ShortName,
                })
                .ToListAsync();
        }

        public async Task<bool> IsDeleted(string studentId)
        {
            var student = await repository.GetByIdAsync<Student>(studentId);

            return student?.IsDeleted ?? false;                
        }
    }
}
