using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class FYPController : Controller
    {
        // GET: FYP
        public ActionResult Index()
        {
            ViewBag.IP = "You will get an IP if you will not work on your FYP!";

            return View();
        }
    }
}