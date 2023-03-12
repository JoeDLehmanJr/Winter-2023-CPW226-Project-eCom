using CPW221_Project_eCom.Data;
using CPW221_Project_eCom.Models;
using Microsoft.AspNetCore.Mvc;

namespace CPW221_Project_eCom.Controllers
{
    public class InoviceItemsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public InoviceItemsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Edit(int id)
        {
            InvoicedItems? invoicedItemsToEdit = await _context.InvoicedItems.FindAsync(id);

            if (invoicedItemsToEdit == null)
            {
                return NotFound();
            }

            return View(invoicedItemsToEdit);
        }

        public async Task<IActionResult> Edit(InvoicedItems invoicedItems)
        {
            if (ModelState.IsValid)
            {
                _context.InvoicedItems.Update(invoicedItems);
                await _context.SaveChangesAsync();

                TempData["Message"] = $"{invoicedItems.ProductId} was updated successfully";
                return RedirectToAction("Index");                
            }
            return View(invoicedItems);
        }

        public async Task<IActionResult> Delete(int id)
        {
            InvoicedItems? invoicedItemsToDelete = await _context.InvoicedItems.FindAsync(id);

            if(invoicedItemsToDelete == null)
            {
                await _context.SaveChangesAsync(); ;
                TempData["Message"] = $"{invoicedItemsToDelete.ProductId} was deleted successfully";
                return RedirectToAction("Index");
            }

            TempData["Message"] = "This Invoiced Item has already been deleted";
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int id)
        {
            InvoicedItems? invoicedItemsDetails = await _context.InvoicedItems.FindAsync(id);

            if (invoicedItemsDetails == null)
            {
                return NotFound();
            }

            return View(invoicedItemsDetails);
        }
    }
}
