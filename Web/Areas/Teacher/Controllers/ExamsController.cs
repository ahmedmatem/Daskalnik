namespace Web.Areas.Teacher.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

    using Core.Contracts;
    using Core.Models.Exam;
    using static Core.Constants.MessageConstants;

    using Web.Extensions;
    using Core.Models.GroupExam;

    public class ExamsController : TeacherBaseController
    {
        private readonly ILogger<ExamsController> logger;
        private readonly IExamService examService;
        private readonly IResourceService resourceService;

        public ExamsController(
            ILogger<ExamsController> _logger, 
            IExamService _examService,
            IResourceService _resourceService)
        {
            logger = _logger;
            examService = _examService;
            resourceService = _resourceService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await examService.GetAllExamsByCreatorAsync(User.Id());
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> AssignToGroup(string groupId)
        {
            var creatorId = User.Id();
            var model = await examService
                .AllExamsNotAssignedToGroupByCreatorAsync(creatorId, groupId);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            CreateExamServiceModel model = new CreateExamServiceModel()
            {
                CreatorAllExamResources = await resourceService
                .GettAllExamsByCreator(User.Id())
                .ToListAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateExamServiceModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            model.CreatorId = User.Id();
            await examService.CreateAsync(model);

            TempData[MessageSuccess] = "Изпитният материал е създаден успешно.";

            return RedirectToAction(nameof(Index));
        }
    }
}
