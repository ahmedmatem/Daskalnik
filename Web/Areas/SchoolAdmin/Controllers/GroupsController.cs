using Core.Contracts;
using Microsoft.AspNetCore.Mvc;
using Web.Extensions;
using static Core.Constants.MessageConstants;

namespace Web.Areas.SchoolAdmin.Controllers
{
    public class GroupsController : SchoolAdminBaseController
    {
        private readonly ITeacherService teacherService;
        private readonly IGroupService groupService;

        public GroupsController(
            ITeacherService _teacherService,
            IGroupService _groupService)
        {
            teacherService = _teacherService;
            groupService = _groupService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var teacher = await teacherService.GetByIdAsync(User.Id());
            if (teacher != null)
            {
                string schoolId = teacher.SchoolId;
                var model = await groupService
                    .GetAllGroupsInSchool(schoolId, User.Id());

                return View(model);
            }

            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Stop(string id, string schoolId)
        {
            var isStopped = await groupService.StopBySchoolAdminAsync(id, schoolId, User.Id());

            if(isStopped)
            {
                TempData[MessageSuccess] = "Групата бе спряна успешно.";
            }
            else
            {
                TempData[MessageSuccess] = "Групата бе пусната успешно.";
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Start(string id, string schoolId)
        {
            var isStarted = await groupService.StartBySchoolAdminAsync(id, schoolId, User.Id());

            if (isStarted)
            {
                TempData[MessageSuccess] = "Групата бе пусната успешно.";
            }
            else
            {
                TempData[MessageSuccess] = "Групата бе спряна успешно.";
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
