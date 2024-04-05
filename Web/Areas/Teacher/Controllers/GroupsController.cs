using Core.Contracts;
using Core.Models.Group;
using Microsoft.AspNetCore.Mvc;
using Web.Extensions;
using static Infrastructure.Constants.DataConstants;
using static Infrastructure.Data.ErrorMessages;
using static Core.Constants.MessageConstants;

namespace Web.Areas.Teacher.Controllers
{
    public class GroupsController : TeacherBaseController
    {
        private readonly IAzureBlobService blobService;
        private readonly ITeacherService teacherService;
        private readonly IGroupService groupService;
        private readonly ITopicService topicService;

        public GroupsController(
            IAzureBlobService _blobService,
            ITeacherService _teacherService,
            IGroupService _groupService,
            ITopicService _topicService)
        {
            blobService = _blobService;
            teacherService = _teacherService;
            groupService = _groupService;
            topicService = _topicService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await groupService.GetAllTeacherGroups(User.Id());
            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(GroupFormServiceModel model, IFormFile postedFile)
        {
            if (postedFile == null)
            {
                ModelState.AddModelError("IconUrl", string.Format(RequiredErrorMessage, ""));
            }
            if (postedFile != null && postedFile.Length > 0)
            {
                if (!postedFile.IsImage())
                {
                    ModelState.AddModelError("IconUrl",
                        string.Format(FileITypeErrorMessage, postedFile.FileName));
                }
                if (postedFile.FileSizeValid(PostedFileMaxSizeInBytes) == false)
                {
                    ModelState.AddModelError("IconUrl",
                        string.Format(FileISizeErrorMessage, PostedFileMaxSizeInBytes / 1024));
                }
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            string blobName = postedFile!.GetRandomBlobName();

            Infrastructure.Data.Models.Teacher? teacher =
                await teacherService.GetByIdAsync(User.Id());

            model.TeacherId = teacher!.Id;
            model.SchoolId = teacher.SchoolId;
            model.IconUrl = blobService.BlobContainerURL + blobName;

            await groupService.AddAsync(model);
            await blobService.UploadFileAsync(postedFile!, blobName);

            TempData[MessageSuccess] = "Групата е създадена успешно.";

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Group(string id)
        {
            var model = await groupService.GetByIdAsync(id);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> AddTopicInGroup(string id)
        {
            //var allTeacherTopics = await topicService.GetAllTopicsByCreatorAsync(User.Id());
            //var notAddedInGroupTopics = allTeacherTopics
            //    .ExceptBy<TopicListItemServiceModel, string>(new List<string> { id }, x => x.Id);


            return View();
        }
    }
}
