using Microsoft.AspNetCore.Mvc;

namespace DNT390RoutingAssignments.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return View();
        }
    }
}
