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
        [Route("login")]
        public IActionResult UserLogin()
        {
            return View(new UserLogin());
        }

        public void SignIn()
        {
            return;
        }

        [Route("register")]
        public IActionResult UserRegister()
        {
            return View(new UserRegister());
        }

        public void CreateUser(UserRegister newUser)
        {
            return;
        }

    }
}