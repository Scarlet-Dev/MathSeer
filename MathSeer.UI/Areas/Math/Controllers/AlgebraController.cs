using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MathSeer.UI.Areas.Math.Controllers
{
    [Route("/algebra")]
    public class AlgebraController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Editor()
        {
            return View();
        }

        public IActionResult Answersheet()
        {
            return View();
        }
    }
}
