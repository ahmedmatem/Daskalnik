using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.SchoolAdmin.Controllers
{
    public class GroupsController : SchoolAdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
