using Lab1Routing.Areas.User.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Lab1Routing.Controllers
{
    [Area("User")]
    public class UserController : Controller
    {

        public IActionResult UserLogin()
        {
            return View();
        }

        public List<UserModel> PutValue()
        {
            var users = new List<UserModel>
                {
                 new UserModel { UserId = 1, UserName = "user@gmail.com", UserPassword = "12345678" },
                };
            return users;
        }

        public IActionResult Logout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult VerifyUser(UserModel user)
        {
            var u = PutValue();
            var ue = u.Where(u => u.UserName.Equals(user.UserName));

            var up = ue.Where(p => p.UserPassword.Equals(user.UserPassword));


            if (up.Count() == 1)
            {
                ViewBag.message = "Login Success";
                return View("User Login Success");
            }
            else
            {
                ViewBag.message = "User LoginFailed";
                return View();
            }
            
        }

    }
}

