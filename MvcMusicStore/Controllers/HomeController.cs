using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    // Controller is the class with methods.
    // View maps the Controller with the common name i.e. Home in this case
    public class HomeController : Controller
    {
        // Index is the method which is mapped with the .cshtml file in View->Home dir
        public ActionResult Index()
        {
            // View will return the Index method of Home controller 
            // and find its view because the name matches. 
            return View();
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