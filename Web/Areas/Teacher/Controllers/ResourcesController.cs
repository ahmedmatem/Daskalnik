using Core.Contracts;
using Core.Models.Resource;
using Microsoft.AspNetCore.Mvc;
using Web.Extensions;
using static Infrastructure.Constants.DataConstants;

namespace Web.Areas.Teacher.Controllers
{
    public class ResourcesController : TeacherBaseController
    {
        private readonly IResourceService resourceService;

        public ResourcesController(
            IResourceService _resourceService)
        {
            resourceService = _resourceService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await resourceService.GetAllREsourcesByCreator(User.Id());

            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(ResourceFormServiceModel model)
        {
            if(model.CreatorId != User.Id()
                || ResourceIconRef.Keys.Contains(model.IconRef) == false)
            {
                return BadRequest();
            }

            await resourceService.AddAsync(model);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}
