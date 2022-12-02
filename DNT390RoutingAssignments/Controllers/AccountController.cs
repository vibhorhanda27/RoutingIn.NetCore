using DNT390RoutingAssignments.Models;
using Microsoft.AspNetCore.Mvc;

namespace DNT390RoutingAssignments.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.UserName.ToLower()== "admin@gmail.com" && model.Password== "12345678")
                {
                    return RedirectToAction("Index","Home", new {area="Admin"});
                }
                else if (model.UserName.ToLower() == "user@gmail.com" && model.Password == "12345678")
                {
                    return RedirectToAction("Index", "Home", new { area = "User" });
                }
              
                
            }
            return View();
        }
    }
}
