using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _2nd_Lecture.Models;

namespace _2nd_Lecture.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            ViewBag.Name = "Zahin";
            ViewBag.Id = "17-35479-3";
            ViewBag.Fname = "Father";
            ViewBag.Mname = "Mother";
            ViewBag.Age = "23";

            TempData["Dream"] = "Guitarist";

            return View();

            
        }

     /*   public ActionResult Details()
        {

            //ViewData["name"] = "Towsif";
            TempData["Name"] = "Towsif"; 
            ViewData["temp"] = "Temp Data";
            //return RedirectToAction("Create");

            return View();

        } */

        public ActionResult Details()
        {
            Person p = new Person();

            p.Name = "Zahin Masroor";
            p.Password = "12345";
            p.Username = "Zahin00X";

            return View(p);


        }

        public ActionResult Create()
        {
            TempData["University"] = "AIUB";
            return View();   

        }
    }
}