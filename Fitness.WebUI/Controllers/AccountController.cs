using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Fitness.Domain.Interfaces;
using Fitness.WebUI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;

namespace Fitness.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAuthenticate authenticate;
        public AccountController(IAuthenticate authenticate)
        {
            this.authenticate = authenticate;
        }

        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
            return View(new LoginViewModel(){
                ReturnUrl = returnUrl
            });
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
           var result = await authenticate.Authenticate(loginViewModel.Email, loginViewModel.Password);
           if(result)
           {
                if(string.IsNullOrEmpty(loginViewModel.ReturnUrl))
                {
                    return RedirectToAction("Index", "Home");
                }
                
                return Redirect(loginViewModel.ReturnUrl);
           }
           else
           {
            ModelState.AddModelError(string.Empty, "Invalid email or password");
            return View(loginViewModel);
           }
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            var result = await authenticate.RegisterUser(registerViewModel.Email, registerViewModel.Password);
            if(result)
            {
                return Redirect("/");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Email already exists");
                return View(registerViewModel);
            }
        }
    }
}