using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1st_Lecture.Controllers
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

        public ActionResult Demo()
        {
            ViewBag.Message = "Your demo page.";

            return View();  
        }

        public ActionResult Projects()
        {
            ViewBag.Message = "Your project page.";

            return View();
        }

        public ActionResult Personal()
        {
            ViewBag.Message = "Your Persoanl page.";

            return View();
        }

        public ActionResult Education()
        {
            ViewBag.Message = "Your Education page.";

            return View();
        }

        public ActionResult References()
        {
            ViewBag.Message = "Your References page.";

            return View();
        }
    }
}