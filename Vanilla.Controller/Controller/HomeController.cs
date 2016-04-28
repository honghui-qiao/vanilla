using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using Vanilla.Service.Implementation;
using Vanilla.Service.Interface;
using Vanilla.Service.ViewModel;

namespace Vanilla.Controller
{
    public class HomeController : System.Web.Mvc.Controller
    {
        public HomeController()
        {
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
