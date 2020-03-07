using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_EF_Insurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Client()
        {
            ViewBag.Message = "Please enter your data here.";

            return View();
        }

        public ActionResult Quote()
        {
            ViewBag.Message = "Here you'll find your quote.";

            return View();
        }

        public ActionResult Admin()
        {
            ViewBag.Message = "This is the admin's overview.";

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