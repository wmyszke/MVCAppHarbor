using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcFilmoteka.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Witaj w portalu Filmoteka!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
