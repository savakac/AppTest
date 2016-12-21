using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.Web.Models;

namespace App.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.config = "config";
            int? number = 2 + 33;

            return View(number);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
			
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Setting = eSetting.Setting.ToString();
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}