using Tab_Task1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Tab_Task1.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        [HttpGet]
        public ActionResult Index()
        {
            List<Student> Studentlist = new List<Student>();
            Studentlist.Add(new Student("Rifat", "101"));
            Studentlist.Add(new Student("Rifat", "101"));
            Studentlist.Add(new Student("Rifat", "101"));
            Studentlist.Add(new Student("Rifat", "101"));
            Studentlist.Add(new Student("Rifat", "101"));
            Studentlist.Add(new Student("Rifat", "101"));
            Studentlist.Add(new Student("Rifat", "101"));
            Studentlist.Add(new Student("Rifat", "101"));
            Studentlist.Add(new Student("Rifat", "101"));
            Studentlist.Add(new Student("Rifat", "101"));
            ViewBag.Data = Studentlist;
            return View();
        }
        [HttpPost]
        public ActionResult Index(SignUP model)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Login","Home");
            }
            return View(model);
        }
        public ActionResult MyProfile()
        {

            return View();
        }
        public ActionResult Logout()
        {
            return RedirectToAction("Login", "Home");
        }
    }
}