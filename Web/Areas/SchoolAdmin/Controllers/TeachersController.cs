using Core.Contracts;
using Core.Models.Teacher;
using Microsoft.AspNetCore.Mvc;
using Web.Extensions;
using static Core.Constants.MessageConstants;

namespace Web.Areas.SchoolAdmin.Controllers
{
    public class TeachersController : SchoolAdminBaseController
    {
        private readonly ITeacherService teacherService;

        public TeachersController(
            ITeacherService _teacherService)
        {
            teacherService = _teacherService;
        }

        public async Task<IActionResult> Index([FromQuery] AllTeachersInSchoolQueryModel model)
        {
            var teacher = await teacherService.GetByIdAsync(User.Id());
            if (teacher != null)
            {
                string schoolId = teacher.SchoolId;
                var teachers = await teacherService.GetAllTeachersInSchool(
                    schoolId, 
                    User.Id(),
                    model.CurrentPage,
                    model.SelectedPage,
                    model.TeachersPerPage,
                    model.Status,
                    model.SearchTerm);

                model.Teachers = teachers?.Teachers ?? Enumerable.Empty<TeacherTableRowServiceModel>();
                model.TotalTeachersCount = teachers?.TotalTeachersCount ?? 0;
                model.CurrentPage = teachers?.CurrentPage ?? 1;

                return View(model);
            }

            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Delete(
            string id, 
            string schoolId,
            [FromQuery] AllTeachersInSchoolQueryModel model)
        {
            var isDeleted = await teacherService.DeleteAsync(id, schoolId, User.Id());

            if (isDeleted)
            {
                TempData[MessageSuccess] = "Учителят бе изтрит успешно.";
            }
            else
            {
                TempData[MessageError] = "Възникна грешка при изтриване на учител.";
            }

            return RedirectToAction(nameof(Index), 
                new 
                {
                    currentPage = model.CurrentPage,
                    selectedPage = model.SelectedPage,
                    searchTerm = model.SearchTerm,
                    status = model.Status,
                    teachersPerPage = model.TeachersPerPage
                });
        }

        [HttpGet]
        public async Task<IActionResult> Restore(
            string id, 
            string schoolId, 
            [FromQuery] AllTeachersInSchoolQueryModel model)
        {
            var isRestored = await teacherService.RestoreAsync(id, schoolId, User.Id());

            if (isRestored)
            {
                TempData[MessageSuccess] = "Учителят бе възстановен успешно.";
            }
            else
            {
                TempData[MessageError] = "Възникна грешка при възстановяване на учител.";
            }

            return RedirectToAction(nameof(Index),
                new
                {
                    currentPage = model.CurrentPage,
                    selectedPage = model.SelectedPage,
                    searchTerm = model.SearchTerm,
                    status = model.Status,
                    teachersPerPage = model.TeachersPerPage
                });
        }

        [HttpGet]
        public async Task<IActionResult> Activate(
            string id, 
            string schoolId,
            [FromQuery] AllTeachersInSchoolQueryModel model)
        {
            var isActivated = await teacherService.ActivateAsync(id, schoolId, User.Id());

            if (isActivated)
            {
                TempData[MessageSuccess] = "Учителят е активиран успешно.";
            }
            else
            {
                TempData[MessageSuccess] = "Възникна грешка при активиране на учител.";
            }

            return RedirectToAction(nameof(Index),
                new
                {
                    currentPage = model.CurrentPage,
                    selectedPage = model.SelectedPage,
                    searchTerm = model.SearchTerm,
                    status = model.Status,
                    teachersPerPage = model.TeachersPerPage
                });
        }
    }
}
