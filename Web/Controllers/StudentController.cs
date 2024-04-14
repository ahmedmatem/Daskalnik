using Core.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web.Extensions;

namespace Web.Controllers
{
    public class StudentController : StudentBaseController
    {
        private readonly IStudentService studentService;

        public StudentController(IStudentService _studentservice)
        {
            studentService = _studentservice;
        }

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
    }
}
