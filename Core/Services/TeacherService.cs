﻿using Core.Contracts;
using Core.Models.ApplicationUser;
using Core.Models.Common;
using Core.Models.Teacher;
using Infrastructure.Data.DataRepository;
using Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using static Core.Claims.CustomUserClaims;
using static Infrastructure.Constants.DataConstants;

namespace Core.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IRepository repository;

        public TeacherService(
            UserManager<ApplicationUser> _userManager,
            IRepository _repository)
        {
            userManager = _userManager;
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
                .Where(t => !t.IsActivated && !t.IsDeleted && t.SchoolId == schoolId)
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

        public async Task<AllTeachersInSchoolQueryModel?> GetAllTeachersInSchool(
            string schoolId,
            string schoolAdminId,
            int currentPage = 1,
            int selectedPage = 1,
            int teachersPerPage = DefaultTeachersPerPage,
            UserStatus status = UserStatus.All,
            string? searchTerm = null)
        {
            var schoolAdmin = await repository.GetByIdAsync<Teacher>(schoolAdminId);

            if (schoolAdmin != null && schoolAdmin.SchoolId == schoolId)
            {
                var allTeachers = repository.AllReadOnly<Teacher>()
                .Where(t => t.SchoolId == schoolId)
                .Select(t => new TeacherTableRowServiceModel()
                {
                    SchoolId = schoolId,
                    TeacherId = t.Id,
                    FullName = t.FullName,
                    IsDeleted = t.IsDeleted,
                    IsActivated = t.IsActivated,
                });

                if(searchTerm != null)
                {
                    string normalizedSearchTerm = searchTerm.ToLower();
                    allTeachers = allTeachers
                        .Where(m => m.FullName.ToLower().Contains(normalizedSearchTerm));
                }

                allTeachers = status switch
                {
                    UserStatus.Active => allTeachers
                        .Where(m => m.IsActivated && !m.IsDeleted),
                    UserStatus.Deleted => allTeachers
                        .Where(m => m.IsDeleted),
                    UserStatus.Pending => allTeachers
                    .Where(m => !m.IsActivated),
                    _ => allTeachers
                };

                allTeachers = allTeachers.OrderBy(m => m.FullName);

                var teachersToShow = await allTeachers
                    .Skip((selectedPage - 1) * teachersPerPage)
                    .Take(teachersPerPage)
                    .ToListAsync();

                var teachersCount = await allTeachers.CountAsync();

                return new AllTeachersInSchoolQueryModel()
                {
                    Teachers = teachersToShow,
                    TotalTeachersCount = teachersCount,
                    CurrentPage = selectedPage
                };
            }

            return null;
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

                    // Remove custom claim of type ActiveClaim from teacher.
                    var user = await userManager.FindByIdAsync(teacherId);
                    await userManager.RemoveClaimAsync(
                        user, new Claim(ActiveClaim.Key, ActiveClaim.Value));

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

                    // Add custom claim of type ActiveClaim for teacher.
                    var user = await userManager.FindByIdAsync(teacherId);
                    await userManager.AddClaimAsync(
                        user, new Claim(ActiveClaim.Key, ActiveClaim.Value));

                    return true;
                }
            }

            return false;
        }

        public async Task CreateAsync(RegisterFormModel model)
        {
            Teacher teacher = new Teacher()
            {
                Id = model.Id,
                FullName = model.FullName,
                SchoolId = model.SchoolId
            };

            await repository.AddAsync(teacher);
            await repository.SaveChangesAsync<Teacher>();
        }

        public async Task<bool> ActivateAsync(string teacherId, string schoolId, string schoolAdminId)
        {
            var schoolAdmin = await repository.GetByIdAsync<Teacher>(schoolAdminId);
            var teacherAsUser = await userManager.FindByIdAsync(teacherId);

            if (schoolAdmin != null && schoolAdmin.SchoolId == schoolId)
            {
                var teacher = await repository.GetByIdAsync<Teacher>(teacherId);
                if (teacher != null &&
                    teacher.SchoolId == schoolId &&
                    teacherAsUser != null)
                {
                    // Add teacher in Role Teacher
                    var addToRoleResult = await userManager.AddToRoleAsync(teacherAsUser, "Teacher");

                    if (addToRoleResult != null)
                    {
                        // Activate teacher.
                        teacher.IsActivated = true;
                        repository.Update(teacher);
                        await repository.SaveChangesAsync<Teacher>();

                        // Add custom claim of type ActiveClaim for teacher.
                        await userManager.AddClaimAsync(
                            teacherAsUser, new Claim(ActiveClaim.Key, ActiveClaim.Value));

                        return true;
                    }
                }
            }

            return false;
        }
    }
}
