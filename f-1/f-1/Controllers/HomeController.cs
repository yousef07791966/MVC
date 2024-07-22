using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace f_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Contact2()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult page()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult prudoct()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult dashboord ()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}