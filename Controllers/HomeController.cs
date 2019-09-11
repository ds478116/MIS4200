using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dominic1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "A Shorter Bio";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Dominic's Contact Page";

            return View();
        }
    }
}