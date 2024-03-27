using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Teacher.Controllers
{
    public class HomeController : TeacherBaseController
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Groups");
        }
    }
}
