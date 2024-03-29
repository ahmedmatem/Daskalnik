using Core.Contracts;
using Core.Models.Topic;
using Microsoft.AspNetCore.Mvc;
using Web.Extensions;

namespace Web.Areas.Teacher.Controllers
{
    public class TopicsController : TeacherBaseController
    {
        private readonly IAzureBlobService azureBlobService;
        private readonly ITopicService topicService;

        public TopicsController(
            IAzureBlobService _azureBlobService,
            ITopicService _topicService)
        {
            azureBlobService = _azureBlobService;
            topicService = _topicService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await topicService.GetAllTopicsByCreatorAsync(User.Id());

            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(TopicFormServiceModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            model.CreatorId = User.Id();
            await topicService.AddAsync(model);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var model = await topicService.GetByIdAsync(id);
            if(model != null && model.CreatorId == User.Id())
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
                if(model.CreatorId == User.Id())
                {
                    await topicService.UpdateAsync(model);
                    return RedirectToAction(nameof(Index));
                }

                return BadRequest();
            }

            return View(model);           
        }
    }
}
