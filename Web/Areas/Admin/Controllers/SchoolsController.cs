using Core.Contracts;
using Core.Models.Admin.Schools;
using Core.Models.Teachers;
using Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Admin.Controllers
{
    public class SchoolsController : AdminBaseController
    {
        private readonly ISchoolService schoolService;
        private readonly ITeacherService teacherService;
        private readonly UserManager<IdentityUser> userManager;

        public SchoolsController(
            ISchoolService _schoolService,
            ITeacherService _teacherService,
            UserManager<IdentityUser> _userManager)
        {
            schoolService = _schoolService;
            teacherService = _teacherService;
            userManager = _userManager;
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

        [HttpGet]
        public async Task<IActionResult> AddSchoolAdmin(string id)
        {
            var school = await schoolService.GetByIdAsync(id);
            if(school == null)
            {
                return BadRequest();
            }

            var teachers = await teacherService.GetSchoolAdminCandidatesAsync(school.Id);

            var model = new AddSchoolAdminFormViewModel()
            {
                School = school, 
                Teachers = teachers ?? new HashSet<TeacherDropdownViewModel>()
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddSchoolAdmin(AddSchoolAdminFormViewModel model)
        {
            var schoolId = model.School.Id;
            var teacherId = model.TeacherId;
            
            await schoolService.TryAddSchoolAdminAsync(schoolId, teacherId);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var model = await schoolService.GetByIdAsync(id);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(SchoolViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await schoolService.UpdateAsync(model);
            }
            catch(ArgumentException)
            {
                ModelState.AddModelError(string.Empty, $"School with id: {model.Id} was not found.");
                return View(model);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
