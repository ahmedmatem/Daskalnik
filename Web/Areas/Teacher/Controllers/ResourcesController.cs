﻿namespace Web.Areas.Teacher.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

    using Core.Contracts;
    using Core.Models.Resource;
    using static Core.Constants.MessageConstants;

    using Web.Extensions;

    using static Infrastructure.Constants.DataConstants;

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

            TempData[MessageSuccess] = ResourceAddMessageSuccess;

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

            TempData[MessageSuccess] = ResourceEditMessageSuccess;

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            // Check if resource already in use by any topic or exam
            if (await resourceService.IsAssignedAsync(id))
            {
                TempData[MessageWarning] = ResourceAssignedMessageWarning;
            }
            else
            {
                // Resource is not assigned and could be deleted.
                await resourceService.DeleteAsync(id);

                TempData[MessageSuccess] = ResourceDeleteMessageSuccess;
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
