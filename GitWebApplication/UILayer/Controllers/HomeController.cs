using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Mvc;

namespace UILayer.Controllers
{

    public class HomeController : Controller
    {
        private string version;

        public HomeController()
        {
            version = ConfigurationManager.AppSettings["Version"];
        }

        // GET: NewCustom
        public ActionResult Index()
        {
            ViewBag.Title = "EVE Site";
            ViewBag.CField = "some text from the bag";
            ViewBag.version = version;
            return View("Home");
        }

    }
}
