using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPWebConfig.Models;

namespace ASPWebConfig.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            object name = System.Configuration.ConfigurationManager.AppSettings["Name"];

            return View(name);
        }

        public ActionResult About()
        {
            object name = System.Configuration.ConfigurationManager.AppSettings["Name"];

            return View(name);
        }

        public ActionResult Contact()
        {
            Demo demo = new Demo() { name = "Test Demo" };

            return View(demo);
        }
    }
}