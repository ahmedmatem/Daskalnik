﻿using Core.Contracts;
using Core.Models.Admin.Schools;
using Infrastructure.Data.DataRepository;
using Infrastructure.Data.Models;
using Infrastructure.Exceptions;
using static Infrastructure.Data.ErrorMessages;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Core.Services
{
    public class SchoolService : ISchoolService
    {
        private readonly IRepository repository;
        private readonly UserManager<IdentityUser> userManager;
        private readonly ILogger<SchoolService> logger;

        public SchoolService(
            IRepository _repository, 
            UserManager<IdentityUser> _userManager,
            ILogger<SchoolService> _logger)
        {
            repository = _repository;
            userManager = _userManager;
            logger = _logger;
        }

        public async Task AddAsync(SchoolFormViewModel model)
        {
            School school = new School()
            {
                Name = model.Name,
                Type = model.Type,
                City = model.City
            };

            await repository.AddAsync(school);
            await repository.SaveChangesAsync<School>();            
        }

        public async Task UpdateSchool(Teacher teacher)
        {
            var school = await repository.GetByIdAsync<School>(teacher.SchoolId);
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
                    SchoolAdmin = s.SchoolAdmin,
                })
                .ToListAsync();
        }

        public async Task<SchoolViewModel?> GetByIdAsync(string id)
        {
            var school = await repository.GetByIdAsync<School>(id);
            if(school != null)
            {
                return new SchoolViewModel()
                {
                    Id = school.Id,
                    Name = school.Name,
                    Type = school.Type,
                    City = school.City
                };
            }

            return new SchoolViewModel();
        }

        public async Task<int> GetSchoolsCountAsync()
        {
            return await repository
                .All<School>()
                .Where(s => !s.IsDeleted)
                .CountAsync();
        }

        public async Task<bool> SchoolExistsAsync(string id)
        {
            return await repository.AllReadOnly<School>().AnyAsync(x => x.Id == id);
        }

        public async Task<bool> TryAddSchoolAdminAsync(string schoolId, string teacherId)
        {
            var school = await repository.GetByIdAsync<School>(schoolId);
            if(school != null && school.SchoolAdmin == null)
            {
                // Get teacher as User - necessary to change the teacher role.
                var teacherAsUser = await userManager.FindByIdAsync(teacherId);
                if(teacherAsUser != null)
                {
                    // Get pure teacher
                    var teacher = await repository.GetByIdAsync<Teacher>(teacherId);
                    // Check if the teacher belongs to school which it has to be added in.
                    if(teacher != null && teacher.SchoolId == schoolId)
                    {
                        if(await userManager.IsInRoleAsync(teacherAsUser, "Teacher"))
                        {
                            var removeFromRole = 
                                await userManager.RemoveFromRoleAsync(teacherAsUser, "Teacher");
                            if(removeFromRole.Succeeded)
                            {
                                // Set teacher in SchoolAdmin role.
                                var addToRoleResult = 
                                    await userManager.AddToRoleAsync(teacherAsUser, "SchoolAdmin");
                                if(addToRoleResult.Succeeded)
                                {
                                    // Activate teacher.
                                    teacher.IsActivated = true;
                                    await repository.SaveChangesAsync<Teacher>();
                                    // Update school with SchoolAdmin teacher.
                                    school.SchoolAdmin = teacher;
                                    await repository.SaveChangesAsync<Teacher>();
                                    return true;
                                }
                            }
                        }
                    }
                }
            }

            return false;
        }

        public async Task UpdateAsync(SchoolViewModel model)
        {
            School? school = await repository.GetByIdAsync<School>(model.Id);
            if(school == null)
            {
                logger.LogError("School with id: {0} was not found", model.Id);
                throw new EntityNotFoundException(SchoolEntityNotFoundErrorMessage);
            }

            school.Id = model.Id;
            school.Name = model.Name;
            school.City = model.City;
            school.Type = model.Type;

            repository.Update(school);
            await repository.SaveChangesAsync<School>();
        }
    }
}
