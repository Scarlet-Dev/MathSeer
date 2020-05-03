using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathSeer.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MathSeer.UI.Controllers
{
    [Route("auth/")]
    public class AuthController : Controller
    {
        [HttpGet("login")]
        public IActionResult LoginPage()
        {
            return View(new UserLogin());
        }

        [HttpGet("register")]
        public IActionResult RegisterPage()
        {
            return View(new UserRegister());
        }
    }
}