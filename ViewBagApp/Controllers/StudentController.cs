using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewBagApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult StudentView()
        {
            ViewBag.Name = "Ansu Mathew";
            ViewBag.Address = "Pookattil House";
            ViewBag.Email = "ansu@gmail.com";
            ViewBag.PhoneNumber = "9976785456";
            ViewBag.College = "Mount Carmel College";
            ViewBag.Department = "Computer Application";
            ViewBag.UserName = "ansu123";
            ViewBag.presentTime = DateTime.Now;
            return View(); ;
        }
    }
}