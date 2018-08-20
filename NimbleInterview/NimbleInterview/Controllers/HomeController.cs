using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NimbleInterview.Models;

namespace NimbleInterview.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(CalculationModel model, string action)
        {
            if (action == null)
            {
                return View(model);
            }

            switch (action)
            {
                case "+":
                    model.Result = model.FirstValue + model.SecondValue;
                    break;
                case "-":                   
                    model.Result = model.FirstValue - model.SecondValue;
                    break;
                case "x":                    
                    model.Result = model.FirstValue * model.SecondValue;
                    break;
                case "÷":                   
                    model.Result = model.FirstValue / model.SecondValue;
                    break;
                case "%":
                    model.Result = model.FirstValue * (model.SecondValue / 100);
                    break;
                default:
                    model.Result = 0;
                    break;
            }
            ViewBag.Result = model.Result;
                return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Hadi's application about page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
