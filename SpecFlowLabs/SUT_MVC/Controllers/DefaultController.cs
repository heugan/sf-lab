using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SUT;
using SUT_MVC.Models;

namespace SUT_MVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        //public async Task<ActionResult> Index(CalculationModel model)
        public ActionResult Index(ViewCalculator model)
            //public ActionResult Index(Calculator model)

        {
            ModelState.Clear();
            Calculator c = new Calculator()
            {
                FirstNumber = model.Term1,
                SecondNumber = model.Term2
            };
            model.Sum = c.Add();
  
            return View(model);
        }
    }
}