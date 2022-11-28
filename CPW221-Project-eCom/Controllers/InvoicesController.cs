using Microsoft.AspNetCore.Mvc;
using CPW221_Project_eCom.Data;
using CPW221_Project_eCom.Models;

namespace CPW221_Project_eCom.Controllers
{
    public class InvoicesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        public async Task<IActionResult> Edit(int id)
        {
            Invoices? invoicesToEdit = await _context.Invoices.FindAsync(id);

            if (invoicesToEdit == null)
            {
                return NotFound();
            }

            return View(invoicesToEdit);
        }

        public async Task<IActionResult> Edit(Invoices invoices)
        {
            if(ModelState.IsValid)
            {
                _context.Invoices.Update(invoices);
                await _context.SaveChangesAsync();

                TempData["Message"] = $"{invoices.OrderNumber} was updated successfully";
                return RedirectToAction("Index");
            }

            return View(invoices);
        }

        public async Task<IActionResult> Delete(int id)
        {
            Invoices invoicesToDelete = await _context.Invoices.FindAsync(id);

            if(invoicesToDelete == null)
            {
                await _context.SaveChangesAsync();
                TempData["Message"] = invoicesToDelete.OrderNumber + " was deleted successfully";
                return RedirectToAction("Index");
            }

            TempData["Message"] = "This Invoice has already been deleted";
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int id)
        {
            Invoices invoicesDetails = await _context.Invoices.FindAsync(id);

            if(invoicesDetails == null)
            {
                return NotFound();
            }

            return View(invoicesDetails);
        }
    }
}
