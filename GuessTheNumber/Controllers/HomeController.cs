using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GuessTheNumber.Models;
using GuessTheNumber.ApplicationLayer;

namespace GuessTheNumber.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = new MyModel();
            model.GetGuessNumber();
            return View(model);
        }
   
        public IActionResult Index(MyModel mymodel)
        {
            mymodel.ShowResult = true;
            var resul = new Result();
            ViewBag.Result = resul.GetResult(mymodel);
            return View(mymodel);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
