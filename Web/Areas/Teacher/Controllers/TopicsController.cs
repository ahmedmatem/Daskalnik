using Core.Models.Topic;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Teacher.Controllers
{
    public class TopicsController : TeacherBaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(TopicFormServiceModel model)
        {
            return View();
        }
    }
}
