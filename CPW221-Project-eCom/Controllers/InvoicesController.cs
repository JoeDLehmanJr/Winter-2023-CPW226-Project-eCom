using Microsoft.AspNetCore.Mvc;

namespace CPW221_Project_eCom.Controllers
{
    public class InvoicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
