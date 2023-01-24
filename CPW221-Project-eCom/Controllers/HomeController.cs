using CPW221_Project_eCom.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CPW221_Project_eCom.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmailProvider _emailProvider;

        public HomeController(ILogger<HomeController> logger, IEmailProvider emailProvider = null)
        {
            _logger = logger;
            _emailProvider = emailProvider;
        }

        public async Task<IActionResult> Index()
        {
            await _emailProvider.SendEmailAsync(null, null, "This is a test of SendGrid functionality", "This is a test of SendGrid functionality", ",strong>This is a test of SendGrid functionality</strong>");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}