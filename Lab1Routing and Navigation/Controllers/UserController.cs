using Microsoft.AspNetCore.Mvc;

namespace Lab1Routing_and_Navigation.Controllers
{
    public class UserController : Controller
    {
        //user
        public IActionResult LoginUser()
        {
            return View();
        }
    }
}
