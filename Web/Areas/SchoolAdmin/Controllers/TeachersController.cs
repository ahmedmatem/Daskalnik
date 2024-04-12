using Core.Contracts;
using Core.Services;
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

        public async Task<IActionResult> Index(string id)
        {
            var model = await teacherService.GetAllTeachersInSchool(id, User.Id());

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(string id, string schoolId)
        {
            var isDeleted = await teacherService.DeleteAsync(id, schoolId, User.Id());

            if (isDeleted)
            {
                TempData[MessageSuccess] = "Учителят бе изтрит успешно.";
            }
            else
            {
                TempData[MessageSuccess] = "Учителят бе възстановен успешно.";
            }

            return RedirectToAction(nameof(Index), new { id = schoolId });
        }

        [HttpGet]
        public async Task<IActionResult> Restore(string id, string schoolId)
        {
            var isRestored = await teacherService.RestoreAsync(id, schoolId, User.Id());

            if (isRestored)
            {
                TempData[MessageSuccess] = "Учителят бе възстановен успешно.";
            }
            else
            {
                TempData[MessageSuccess] = "Групата бе изтрит успешно.";
            }

            return RedirectToAction(nameof(Index), new { id = schoolId });
        }
    }
}
