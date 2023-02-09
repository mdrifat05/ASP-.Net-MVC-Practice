using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tab_Task1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Login()
        {

            return View();
        }
        public ActionResult LoginSubmit()
        {
            TempData["Msg"] = "Login Successful";
            return RedirectToAction("Index", "Dashboard");
        }
        public ActionResult SignUp()
        {
            return View();
        }
    }
}