using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathSeer.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MathSeer.UI.Controllers
{
    [Route("/auth")]
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return Redirect("auth/login");
        }

        [HttpPost, Route("login")]
        public IActionResult UserLogin()
        {
            return View(new UserLogin());
        }

        public IActionResult CheckLogin()
        {
            return Redirect("/");
        }

        [HttpPost, Route("register")]
        public IActionResult UserRegister()
        {
            return View(new UserRegister());
        }

        public IActionResult NewUser()
        {
            return Redirect("/");
        }
    }
}