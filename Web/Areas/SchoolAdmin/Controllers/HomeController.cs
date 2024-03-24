using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.SchoolAdmin.Controllers
{
    public class HomeController : SchoolAdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
