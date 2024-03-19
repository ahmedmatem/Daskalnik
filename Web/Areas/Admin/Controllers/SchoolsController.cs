using Core.Contracts;
using Core.Models.Admin.Schools;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Admin.Controllers
{
    public class SchoolsController : AdminBaseController
    {
        private readonly ISchoolService schoolService;

        public SchoolsController(ISchoolService _schoolService)
        {
            schoolService = _schoolService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await schoolService.GetAllAsync();

            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(SchoolFormViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            await schoolService.AddAsync(model);

            return RedirectToAction(nameof(Index));
        }
    }
}
