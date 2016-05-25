using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcAutofac.Models;
using MvcAutofac.Services;

namespace MvcAutofac.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICalculatorService _calculatorService;

        public HomeController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }
        
        // GET: Home
        public ActionResult Index()
        {
            var stringOfNumbers = "1234";

            var model = new IndexViewModel
                        {
                            Day = DateTime.UtcNow.DayOfWeek.ToString(),
                            stringOfNumbers = stringOfNumbers,
                            CalculationResult = _calculatorService.Calculate(stringOfNumbers)
            };
            
            return View(model);
        }
    }
}