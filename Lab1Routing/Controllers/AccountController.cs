using Lab1Routing.Areas.Admin.Model;
using Microsoft.AspNetCore.Mvc;

namespace Lab1Routing.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public List<LoginModel> PutValue()
        {
            var users = new List<LoginModel>
                {
                 new LoginModel { Id = 1, UserName = "admin@gmail.com", Password = "12345678" },
                };
            return users;
        }

        public IActionResult Logout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Verify(LoginModel user)
        {
            var u = PutValue();
            var ue = u.Where(u => u.UserName.Equals(user.UserName));

            var up = ue.Where(p => p.Password.Equals(user.Password));


            if (up.Count() == 1) 
            {
                ViewBag.message = "Admin Login Success";
                return View("LoginSuccess");
            }
            else
            {
                ViewBag.message = "Admin LoginFailed";
                return View("Login");
            }
           // return View();
        }

    }
}


