using Core.Contracts;
using Core.Models.Resource;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Extensions;
using static Infrastructure.Constants.DataConstants;
using static Core.Constants.MessageConstants;

namespace Web.Areas.Teacher.Controllers
{
    public class ResourcesController : TeacherBaseController
    {
        private readonly IResourceService resourceService;
        private readonly IAzureBlobService azureBlobService;

        public ResourcesController(
            IResourceService _resourceService, 
            IAzureBlobService _azureBlobService)
        {
            resourceService = _resourceService;
            azureBlobService = _azureBlobService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await resourceService
                .GetAllByCreator(User.Id())
                .ToListAsync();

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

            TempData[MessageSuccess] = "Ресурсът е добавен успешно.";

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var model = await resourceService.GetByIdAsync(id);
            if(model != null && model.CreatorId == User.Id())
            {
                return View(model);
            }

            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ResourceFormServiceModel model)
        {
            if (model.CreatorId != User.Id()
                || ResourceIconRef.Keys.Contains(model.IconRef) == false)
            {
                return BadRequest();
            }

            await resourceService.UpdateAsync(model);

            TempData[MessageSuccess] = "Ресурсът е променен успешно.";

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(string id)
        {
            return View();
        }
    }
}
