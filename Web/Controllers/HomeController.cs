using Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly SignInManager<ApplicationUser> signInManager;

        public HomeController(
            ILogger<HomeController> _logger,
            SignInManager<ApplicationUser> _signInManager)
        {
            logger = _logger;
            signInManager = _signInManager;
        }

        public IActionResult Index()
        {
            if (User.IsInRole("Admin"))
            {
                return RedirectToAction("Index", "Home", new { area = "Admin"});
            }
            else if (User.IsInRole("SchoolAdmin"))
            {
                return RedirectToAction("Index", "Home", new { area = "SchoolAdmin" });
            }
            else if(User.IsInRole("Teacher"))
            {
                return RedirectToAction("Index", "Home", new { area = "Teacher" });
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult NotActivated()
        {
            return View();
        }
    }
}
