namespace TipCalculator.Controllers

{

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TipCalculator.Models;


    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()

        {
            ViewBag.Fifteen = 0;
            ViewBag.Twenty = 0;
            ViewBag.Twentyfive = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(Calculator calculator)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Fifteen = calculator.CalculateTip(0.15);
                ViewBag.Twenty = calculator.CalculateTip(0.20); 
                ViewBag.Twentyfive = calculator.CalculateTip(0.25); 
            }
            else
            {
                ViewBag.Fifteen = 0;
                ViewBag.Twenty = 0;
                ViewBag.Twentyfive = 0;
            }
            return View(calculator);
        }
    }
}
