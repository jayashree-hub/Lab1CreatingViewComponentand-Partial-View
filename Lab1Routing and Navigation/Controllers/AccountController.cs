using Lab1Routing_and_Navigation.Model;
using Microsoft.AspNetCore.Mvc;

namespace Lab1Routing_and_Navigation.Controllers
{
    public class AccountController : Controller
    {
        //private readonly ApplicationDbContext dbcontext;

        public AccountController() { }
        [HttpGet, Route("Login")]
        public IActionResult Login()
        {
            var response = new LoginVM();
            response.UserName = "admin@gmail.com";
            response.Password = "12345678";
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM login)
        {
            var response = new LoginVM();
            //admin @gmail.com
            //12345678
            response.UserName = login.UserName;
            response.Password = login.Password;
            if(response.UserName != null)
            {
                TempData["Error"] = "wrong credentials . please try again";
            }
            if(response.UserName == "admin@gmail.com" && response.Password == "12345678")
            {

            }


            //var user = "admin @gmail.com";
            //var pwd =  "12345678";

            return View(response);
            //TempData["Error"] = "Error";

        }

        }
      
    }


