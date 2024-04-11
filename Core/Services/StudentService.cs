using Core.Contracts;
using Core.Models.Common;
using Core.Models.GroupStudent;
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
    }
}
