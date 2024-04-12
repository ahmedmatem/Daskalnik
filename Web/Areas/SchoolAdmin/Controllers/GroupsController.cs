using Core.Contracts;
using Microsoft.AspNetCore.Mvc;
using Web.Extensions;
using static Core.Constants.MessageConstants;

namespace Web.Areas.SchoolAdmin.Controllers
{
    public class GroupsController : SchoolAdminBaseController
    {
        private readonly IGroupService groupService;

        public GroupsController(
            IGroupService _groupService)
        {
            groupService = _groupService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string id)
        {
            var model = await groupService.GetAllGroupsInSchool(id);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Stop(string id, string schoolId)
        {
            var isStopped = await groupService.StopAsync(id, schoolId, User.Id());

            if(isStopped)
            {
                TempData[MessageSuccess] = "Групата бе спряна успешно.";
            }
            else
            {
                TempData[MessageSuccess] = "Групата бе пусната успешно.";
            }

            return RedirectToAction(nameof(Index), new { id = schoolId });
        }

        [HttpGet]
        public async Task<IActionResult> Start(string id, string schoolId)
        {
            var isStarted = await groupService.StartAsync(id, schoolId, User.Id());

            if (isStarted)
            {
                TempData[MessageSuccess] = "Групата бе пусната успешно.";
            }
            else
            {
                TempData[MessageSuccess] = "Групата бе спряна успешно.";
            }

            return RedirectToAction(nameof(Index), new { id = schoolId });
        }
    }
}
