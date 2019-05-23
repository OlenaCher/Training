using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrainingApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Fibonacci()
        //{
        //    ViewBag.Message = "Enter the length of the Fibonacci sequence";

        //    return View();
        //}

        public ActionResult Fibonacci(string length = "")
        {
            ViewBag.sequence = length;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}