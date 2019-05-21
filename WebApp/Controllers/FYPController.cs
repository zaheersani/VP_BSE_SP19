using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebApp.Models;

namespace WebApp.Controllers
{
    public class FYPController : Controller
    {
        // GET: FYP
        public ActionResult Index()
        {
            ViewBag.Msg = "You will get an IP if you will not work on your FYP!";

            return View();
        }
        public ActionResult Search(int? id)
        {
            ViewBag.Msg = "ID is " + id;

            return View("Index");
        }
        public ActionResult Details()
        {
            FYP fypObj = new FYP()
            {
                Title = "Intelligent Car Management System",
                Members = 4
            };
            return View(fypObj);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(FYP obj)
        {
            ViewBag.Msg = obj.Title + " has been added!";
            return View(obj);
        }

        public ActionResult ProjectDetails()
        {
            FYPView fypObj = new FYPView()
            {
                Project = "Intelligent Car Management System",
                Supervisor = "Ahmed Ali"
            };
            return View(fypObj);
        }
    }
}