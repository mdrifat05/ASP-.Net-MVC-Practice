﻿using FormSubmission.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormSubmission.Controllers
{
    public class RegController : Controller
    {
        // GET: Reg
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Registration model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Profile");
            }
            return View(model);
        }
        public ActionResult profile(FormCollection forms) 
        {
            ViewBag.Uname = forms["Uname"];
            ViewBag.Pass = forms["Pass"];
            return View(forms);
        }
    }
}