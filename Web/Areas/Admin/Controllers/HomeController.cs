using Core.Contracts;
using Core.Models.Admin.Home;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Admin.Controllers
{
    public class HomeController : AdminBaseController
    {
        private readonly ISchoolService schoolService;
        private readonly ITeacherService teacherService;
        private readonly IGroupService groupService;
        private readonly IStudentService studentService;

        public HomeController(
            ISchoolService _schoolService,
            ITeacherService _teacherService,
            IGroupService _groupService,
            IStudentService _studentService)
        {
            schoolService = _schoolService;
            teacherService = _teacherService;
            groupService = _groupService;
            studentService = _studentService;
        }

        public async Task<IActionResult> Index()
        {
            int schoolsCount = await schoolService.GetSchoolsCountAsync();
            int teachersCount = await teacherService.GetTeachersCountAsync();
            int groupsCount = await groupService.GetGroupsCountAsync();
            int studentsCount = await studentService.GetStudentsCountAsync();

            IndexViewModel model = new IndexViewModel()
            {
                SchoolsCount = schoolsCount,
                TeachersCount = teachersCount,
                GroupsCount = groupsCount,
                StudentsCount = studentsCount,
            };
            return View(model);
        }
    }
}
