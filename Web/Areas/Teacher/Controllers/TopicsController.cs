namespace Web.Areas.Teacher.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

    using Web.Extensions;

    using Core.Contracts;
    using Core.Models.Topic;
    using static Core.Constants.MessageConstants;

    public class TopicsController : TeacherBaseController
    {
        private readonly IAzureBlobService azureBlobService;
        private readonly ITopicService topicService;
        private readonly IResourceService resourceService;
        private readonly ITopicResourceService topicResourceService;

        public TopicsController(
            IAzureBlobService _azureBlobService,
            ITopicService _topicService,
            IResourceService _resourceService,
            ITopicResourceService _topicResourceService)
        {
            azureBlobService = _azureBlobService;
            topicService = _topicService;
            resourceService = _resourceService;
            topicResourceService = _topicResourceService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await topicService.GetAllTopicsByCreatorAsync(User.Id());

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            TopicFormServiceModel model = new TopicFormServiceModel()
            {
                CreatorAllResources = await resourceService
                .GetAllByCreator(User.Id())
                .ToListAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(TopicFormServiceModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            model.CreatorId = User.Id();
            await topicService.AddAsync(model);

            TempData[MessageSuccess] = "Темата е добавена успешно.";

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var model = await topicService.GetByIdAsync(id);
            if (model != null && model.CreatorId == User.Id())
            {
                return View(model);
            }

            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(TopicFormServiceModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.CreatorId == User.Id())
                {
                    await topicService.UpdateAsync(model);

                    TempData[MessageSuccess] = "Темата е променена успешно.";

                    return RedirectToAction(nameof(Index));
                }

                return BadRequest();
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Topic(string id)
        {
            var model = await topicService.GetByIdAsync(id);
            if (model != null && model.CreatorId == User.Id())
            {
                return View(model);
            }

            return BadRequest();
        }

        [HttpGet]
        public async Task<JsonResult> DeleteResourceFromTopicAjax(
            string topicId,
            string creatorId,
            string resourceId)
        {
            await topicResourceService.DeleteAsync(topicId, resourceId);

            return new JsonResult(new { message = "Ресурсът е премахнат успешно от темата." });
        }
    }
}
