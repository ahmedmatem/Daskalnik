using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.SchoolAdmin.Controllers
{
    public class TeachersController : SchoolAdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
