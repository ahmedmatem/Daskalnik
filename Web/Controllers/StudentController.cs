using Core.Contracts;
using Microsoft.AspNetCore.Mvc;
using Web.Extensions;

namespace Web.Controllers
{
    public class StudentController : StudentBaseController
    {
        private readonly IStudentService studentService;
        private readonly IGroupService groupService;

        public StudentController(
            IStudentService _studentservice,
            IGroupService _groupService)
        {
            studentService = _studentservice;
            groupService = _groupService;
        }

        [HttpGet]
        public async Task<IActionResult> Groups()
        {
            string studentId = User.Id();
            var model = await studentService.GetAllStudentGroups(studentId);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Group(string id)
        {
            var model = await groupService.GetStudentGroup(id);
            if(model == null)
            {
                return NotFound();
            }

            return View(model);
        }
    }
}
