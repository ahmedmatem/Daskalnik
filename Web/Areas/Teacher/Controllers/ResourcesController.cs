using Core.Models.Resource;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using static Infrastructure.Constants.DataConstants;

namespace Web.Areas.Teacher.Controllers
{
    public class ResourcesController : TeacherBaseController
    {
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
        public IActionResult Add(ResourceFormServiceModel model)
        {
            // ContentType = "image/png"
            // ContentType = "application/vnd.ms-excel"
            // ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
            // ContentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
            // ContentType = "application/pdf"

            if (model.ResourceFile != null)
            {

            }


            return View();
        }
    }
}
