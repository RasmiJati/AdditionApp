using AdditionApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdditionApp.Controllers
{
    public class SIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(SI s)
        {
            ViewBag.result =  "SI is  : " + (s.P * s.T  * s.R) /100;
            return View();
        }
    }
}
