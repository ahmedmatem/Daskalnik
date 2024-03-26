using Core.Models.Group;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Teacher.Controllers
{
    public class GroupsController : TeacherBaseController
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
        public IActionResult Add(GroupFormViewModel model, IFormFile iconUrl)
        {


            return View();
        }
    }
}
