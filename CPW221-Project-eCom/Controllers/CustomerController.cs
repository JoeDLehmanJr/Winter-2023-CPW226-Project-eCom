using Microsoft.AspNetCore.Mvc;
using CPW221_Project_eCom.Models;

namespace CPW221_Project_eCom.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel loginModel)
        {
            if (ModelState.IsValid)
            {
                // Get data from Models/Customer.cs
                CustomerLogin c = (from CustomerLogin in _context.Customer
                              where CustomerLogin.CustomerId = loginModel.CustomerId);
            }

            return View(loginModel);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
    }
}
