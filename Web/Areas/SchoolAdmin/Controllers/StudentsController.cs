using Core.Contracts;
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

        public async Task<IActionResult> Index()
        {
            var teacher = await teacherService.GetByIdAsync(User.Id());
            if (teacher != null)
            {
                string schoolId = teacher.SchoolId;
                var model = await studentService
                    .GetAllStudentsInSchool(schoolId, User.Id());

                return View(model);
            }

            return NotFound();
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
                TempData[MessageError] = "Възникна грешка при изтриване на ученик.";
            }

            return RedirectToAction(nameof(Index));
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
                TempData[MessageError] = "Възникна грешка при възстановяване на ученик.";
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
