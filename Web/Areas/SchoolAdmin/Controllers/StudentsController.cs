using Core.Contracts;
using Core.Services;
using Microsoft.AspNetCore.Mvc;
using Web.Extensions;
using static Core.Constants.MessageConstants;

namespace Web.Areas.SchoolAdmin.Controllers
{
    public class StudentsController : SchoolAdminBaseController
    {
        private readonly ITeacherService teacherService;
        private readonly IStudentService studentService;

        public StudentsController(
            ITeacherService _teacherService,
            IStudentService _studentService)
        {
            teacherService = _teacherService;
            studentService = _studentService;
        }

        public async Task<IActionResult> Index(string id)
        {
            if (id == null)
            {
                var teacher = await teacherService.GetByIdAsync(User.Id());
                if (teacher != null)
                {
                    id = teacher.SchoolId;
                }
            }
            var model = await studentService.GetAllStudentsInSchool(id!, User.Id());

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(string id, string schoolId)
        {
            var isDeleted = await studentService.DeleteAsync(id, schoolId, User.Id());

            if (isDeleted)
            {
                TempData[MessageSuccess] = "Ученикът бе изтрит успешно.";
            }
            else
            {
                TempData[MessageSuccess] = "Ученикът бе възстановен успешно.";
            }

            return RedirectToAction(nameof(Index), new { id = schoolId });
        }

        [HttpGet]
        public async Task<IActionResult> Restore(string id, string schoolId)
        {
            var isRestored = await studentService.RestoreAsync(id, schoolId, User.Id());

            if (isRestored)
            {
                TempData[MessageSuccess] = "Ученикът бе възстановен успешно.";
            }
            else
            {
                TempData[MessageSuccess] = "Ученикът бе изтрит успешно.";
            }

            return RedirectToAction(nameof(Index), new { id = schoolId });
        }
    }
}
