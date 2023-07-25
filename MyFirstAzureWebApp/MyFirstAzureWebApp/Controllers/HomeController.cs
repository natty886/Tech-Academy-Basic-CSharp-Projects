using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstAzureWebApp.Controllers
{
    public class HomeController : Controller
    {
        public static DateTime UtcNow { get; }
        public ActionResult Index()
        {
            DateTime serverTime = DateTime.UtcNow;
            return View(serverTime);
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
    }
}