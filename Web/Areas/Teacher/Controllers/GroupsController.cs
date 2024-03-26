using Core.Contracts;
using Core.Models.Group;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Teacher.Controllers
{
    public class GroupsController : TeacherBaseController
    {
        private readonly IAzureBlobService blobService;

        public GroupsController(IAzureBlobService _blobService)
        {
            blobService = _blobService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(GroupFormViewModel model, 
            IFormFile postedFile)
        {
            await blobService.UploadFileAsync(postedFile);


            return RedirectToAction(nameof(Index));
        }
    }
}
