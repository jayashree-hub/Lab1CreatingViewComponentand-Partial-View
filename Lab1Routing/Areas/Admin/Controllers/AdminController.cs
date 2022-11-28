
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab1Routing.Areas.Admin.Model;


namespace Lab1Routing.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        public ViewResult Login()
        {
           // return View("~/Views/Admin/Login.cshtml");
            return View();
        }

        //[HttpPost]
        //public IActionResult Login(LoginModel model)
        //{
        //    if(ModelState.IsValid)
        //    {
        //        return RedirectToAction("Index", "Home", new { area = "User" });
        //    }
        //    return View();
        //}


        //    public IActionResult Login()
        //    {
        //        //return View();
        //        return View("Views/Admin/Login.cshtml");
        //        // return View("~/path/to/your/login.cshtml");
        //    }
        //    //C:\Users\lenovo\source\repos\Lab1CreatingViewComponentand Partial View\Lab1Routing\Area\Admin\Views\Admin\Login.cshtml
        //    //C:\Users\lenovo\source\repos\Lab1CreatingViewComponentand Partial View\Lab1Routing\Area\Admin\Views\Login.cshtml
        //    public List<LoginModel> PutValue()
        //    {
        //        var users = new List<LoginModel>
        //        {
        //            new LoginModel{Id=1,UserName="amitkumar",Password="abc123"},
        //            //new LoginModel{id=2,username="lisa",password="xyz546"},
        //            //new UserModel{id=3,username="virat",password="pnpc465"},
        //            //new UserModel{id=4,username="trina",password="urt324"}
        //        };

        //        return users;
        //    }

        //    [HttpPost]
        //    public IActionResult Verify(LoginModel usr)
        //    {
        //        var u = PutValue();

        //        var ue = u.Where(u => u.UserName.Equals(usr.UserName));

        //        var up = ue.Where(p => p.Password.Equals(usr.Password));

        //        if (up.Count() == 1)
        //        {
        //            ViewBag.message = "Login Success";
        //            return View("LoginSuccess");
        //        }
        //        else
        //        {
        //            ViewBag.message = "Login Failed";
        //            return View();
        //        }
        //    }
        //}
    }
}


