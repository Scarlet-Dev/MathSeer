using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MathSeer.UI.Controllers
{
    [Route("/math")]
    public class MathController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet, Route("/algebra")]
        public IActionResult Algebra()
        {
            return View();
        }

        [HttpGet, Route("/trigs")]
        public IActionResult Trig()
        {
            return View();
        }
    }
}