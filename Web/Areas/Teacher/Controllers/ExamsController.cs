namespace Web.Areas.Teacher.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class ExamsController : TeacherBaseController
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Add()
        {
            return View();
        }
    }
}
