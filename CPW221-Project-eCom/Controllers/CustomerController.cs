﻿using Microsoft.AspNetCore.Mvc;
using CPW221_Project_eCom.Models;
using CPW221_Project_eCom.Data;

namespace CPW221_Project_eCom.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CustomerController(ApplicationDbContext context)
        {

            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        /*public IActionResult Login(LoginViewModel loginModel)
        {
            if (ModelState.IsValid)
            {
                // Get data from Models/Customer.cs
                CustomerLogin? c = (from CustomerLogin in _context.CustomerLogin
                              where CustomerLogin.UserName = loginModel.UserName &&
                              CustomerLogin.Password = loginModel.Password);

                if (c != null)
                {
                    LogUserIn(loginModel.UserName);
                    return RedirectToAction("Index", "Home");
                }
            }

            return View(loginModel);
        }*/

        

        private void LogUserIn(string UserName)
        {
            HttpContext.Session.SetString("UserName", UserName);
        }
    }
}
