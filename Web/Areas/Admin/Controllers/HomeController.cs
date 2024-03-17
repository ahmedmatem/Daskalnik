using Core.Contracts;
using Core.Models.Admin.Home;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Admin.Controllers
{
    public class HomeController : AdminBaseController
    {
        private readonly ISchoolService schoolService;

        public HomeController(ISchoolService _schoolService)
        {
            schoolService = _schoolService;
        }

        public async Task<IActionResult> Index()
        {
            int schoolsCount = await schoolService.GetSchoolsCountAsync();
            IndexViewModel model = new IndexViewModel()
            {
                SchoolsCount = schoolsCount,
                TeachersCount = 5,
                GroupsCount = 5,
                StudentsCount = 5,
            };
            return View(model);
        }
    }
}
