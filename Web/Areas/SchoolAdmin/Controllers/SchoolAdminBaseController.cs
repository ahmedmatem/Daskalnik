using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.SchoolAdmin.Controllers
{
    [Area("SchoolAdmin")]
    [Authorize(Roles = "SchoolAdmin")]
    public class SchoolAdminBaseController : Controller
    {
    }
}
