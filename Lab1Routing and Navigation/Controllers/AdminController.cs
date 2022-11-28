using Microsoft.AspNetCore.Mvc;

namespace Lab1Routing_and_Navigation.Controllers
{
    public class AdminController : Controller
    {

        //Admin

        public IActionResult LoginAdmin()
        {
            return View();
        }
    }
}
