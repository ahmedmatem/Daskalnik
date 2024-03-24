using Core.Contracts;
using Core.Models.Admin.Schools;
using Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Web.Extensions;

namespace Web.Areas.SchoolAdmin.Controllers
{
    public class HomeController : SchoolAdminBaseController
    {
        private readonly ITeacherService teacherService;
        private readonly ISchoolService schoolService;

        public HomeController(
            ITeacherService _teacherService, 
            ISchoolService _schoolService)
        {
            teacherService = _teacherService;
            schoolService = _schoolService;

        }

        public async Task<IActionResult> Index()
        {
            var teacher = await teacherService.GetByIdAsync(User.Id());
            var school = await schoolService.GetByIdAsync(teacher!.SchoolId);
            if(school == null)
            {
                return NotFound();
            }

            ViewData["SchoolName"] = school.Type + " " + school.Name + " - " + school.City;

            return View();
        }
    }
}
