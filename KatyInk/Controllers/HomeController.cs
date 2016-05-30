using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KatyInk.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calculator()
        {
            return View();
        }

        public ActionResult YodaInstructor()
        {
            return View();
        }
    }
}