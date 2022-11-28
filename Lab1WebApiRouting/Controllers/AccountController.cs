using Lab1WebApiRouting.Model;
//using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
//using System.Reflection.Metadata.Ecma335;
//using Xamarin.Essentials;

namespace Lab1WebApiRouting.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult LoginPage()
        {
            var response = new LoginModel();

            return View();
        }
       
        public IActionResult LogoutPage()
        {
            return View("Logout");
        }
        public IActionResult Index()
        {
            return View("Index");
        }

        public List<LoginModel> loginvalue()

        {
            var users = new List<LoginModel>();
            {
                new LoginModel { Id = 1, Username = "JJJJ", Email = "admin@gmail.com", Password = "12345678" };
                
            };
            return users;

        }
        [HttpPost]
        public IActionResult Verify(LoginModel lm)
        {
            var u  = loginvalue();
            var ue = u.Where(u => u.Username.Equals(lm.Username));
            var up = ue.Where(p => p.Email.Equals(lm.Email));
            var pe = up.Where(k => k.Password.Equals(lm.Password));
            if(up.Count() == 1)
            {
                ViewBag.Message = "Login Success";
                return View("Login Success");
            }
            else
            {
                ViewBag.Message = "Login failed";
                return View("Login failed ");

            }

        }
       




       
    }
}
