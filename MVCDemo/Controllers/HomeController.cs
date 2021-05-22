using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewData["Message"] = "Welcome to ASP .NET training.";
            ViewBag.Countries = new List<string>()
            {
                "India",
                "USA",
                "Mexico"
            };
            return View();
        }
    }
}