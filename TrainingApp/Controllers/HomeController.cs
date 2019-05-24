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

        public ActionResult Fibonacci()
        {
            ViewBag.Message = "Enter the length of the Fibonacci sequence";
            ViewBag.Sequence = "";
            return View();
        }

        [HttpPost]
        public ActionResult Fibonacci(string length)
        {
            ViewBag.Message = "Enter the length of the Fibonacci sequence";
            if (int.TryParse(length, out int sequenceLength))
            {
                try
                {
                    ViewBag.Sequence = Models.Fibonacci.ToString(Models.Fibonacci.GetFibonacciNumbers(sequenceLength));
                }
                catch (OverflowException)
                {
                    ViewBag.Sequence = $"Please enter length less than {length}";
                }
                catch
                {
                    ViewBag.Sequence = $"Something went wrong";
                }
            }
            else
            {
                ViewBag.Sequence = "Length is not a number";
            }
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}