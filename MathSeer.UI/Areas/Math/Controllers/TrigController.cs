﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MathSeer.UI.Areas.Math.Controllers
{
    public class TrigController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
