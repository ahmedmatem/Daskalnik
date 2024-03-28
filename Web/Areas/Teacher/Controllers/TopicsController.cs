using Core.Contracts;
using Core.Models.Topic;
using Microsoft.AspNetCore.Mvc;
using Web.Extensions;

namespace Web.Areas.Teacher.Controllers
{
    public class TopicsController : TeacherBaseController
    {
        private readonly IAzureBlobService azureBlobService;

        public TopicsController(IAzureBlobService _azureBlobService)
        {
            azureBlobService = _azureBlobService;            
        }

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
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            model.CreaterId = User.Id();
            

            return View(model);
        }
    }
}
