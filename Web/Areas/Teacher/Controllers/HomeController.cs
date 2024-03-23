using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Teacher.Controllers
{
    [Area("Teacher")]
    public class HomeController : TeacherBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
