using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _23_7_2024.Controllers
{
    public class HomeController : Controller
    {


        [HttpGet]
        public ActionResult Contact(FormCollection form )
        {
            ViewBag.name= form["name"] ;
            ViewBag.age = form["age"];
            ViewBag.gender = form["gender"];
            ViewBag.department = form["department"];
            return View();
        }

        [HttpPost]
        [ActionName("Contact")]
        public ActionResult Feedme(FormCollection form)
        {
            ViewBag.name = form["name"];
            ViewBag.age = form["age"];
            ViewBag.gender = form["gender"];
            ViewBag.department = form["department"];
            return View();
        }
       
    }
}