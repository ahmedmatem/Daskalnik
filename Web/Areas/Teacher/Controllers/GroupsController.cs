using Core.Contracts;
using Core.Models.Group;
using Microsoft.AspNetCore.Mvc;
using Web.Extensions;
using static Infrastructure.Constants.DataConstants;
using static Infrastructure.Data.ErrorMessages;
using static Core.Constants.MessageConstants;
using Core.Models.GroupTopic;
using System.Security.Claims;
using Infrastructure.Data.Models;

namespace Web.Areas.Teacher.Controllers
{
    public class GroupsController : TeacherBaseController
    {
        private readonly IAzureBlobService blobService;
        private readonly ITeacherService teacherService;
        private readonly IGroupService groupService;
        private readonly ITopicService topicService;
        private readonly IStudentService studentService;

        public GroupsController(
            IAzureBlobService _blobService,
            ITeacherService _teacherService,
            IGroupService _groupService,
            ITopicService _topicService,
            IStudentService _studentService)
        {
            blobService = _blobService;
            teacherService = _teacherService;
            groupService = _groupService;
            topicService = _topicService;
            studentService = _studentService;
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
        public async Task<IActionResult> Add(
            GroupFormServiceModel model,
            IFormFile postedFile)
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
            var model = await topicService
                .GetAllCreatorTopicsExcludedFromGroupAsync(id, User.Id());

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddTopicInGroup(
            GroupTopicSelectFormServiceModel model)
        {
            IEnumerable<string> selectedTopicsIds = model.TopicsListToAdd
                .Where(t => t.IsChecked)
                .Select(t => t.Key);

            if (selectedTopicsIds.Any())
            {
                await groupService.AddTopicsInGroupAsync(
                    model.GroupId, selectedTopicsIds);
            }

            if (selectedTopicsIds.Count() > 1)
            {
                TempData[MessageSuccess] = "Темите бяха добавени успешно";
            }
            else
            {
                TempData[MessageSuccess] = "Темата беше добавена успешно";
            }

            return RedirectToAction(nameof(Group), new { id = model.GroupId });
        }

        [HttpGet]
        public async Task<IActionResult> RemoveTopicFromGroup(
            string groupId, string topicId)
        {
            var succes = await groupService.RemoveTopicFromGroupAsync(topicId, groupId);

            if(succes)
            {
                TempData[MessageSuccess] = "Темата беше премахната успешно.";
            }
            else
            {
                TempData[MessageError] = "Възникна грешка при премахване на темата.";
            }
            
            return RedirectToAction(nameof(Group), new { id = groupId });
        }

        [HttpGet]
        public async Task<IActionResult> AddStudentInGroup(string id)
        {
            var model = await studentService
                .GettAllStudentsInSchoolExcludedFromGroupAsync(id, User.Id());

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> RemoveStudentFromGroup(
            string groupId, string studentId)
        {
            var succes = await groupService.RemoveStudentFromGroupAsync(studentId, groupId);

            if (succes)
            {
                TempData[MessageSuccess] = "Ученикът беше премахнат успешно.";
            }
            else
            {
                TempData[MessageError] = "Възникна грешка при премахване на ученика.";
            }

            return RedirectToAction(nameof(Group), new { id = groupId });
        }
    }
}
