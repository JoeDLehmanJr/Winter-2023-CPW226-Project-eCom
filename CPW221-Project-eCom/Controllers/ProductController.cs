using Microsoft.AspNetCore.Mvc;
using CPW221_Project_eCom.Models;
using CPW221_Project_eCom.Data;

namespace CPW221_Project_eCom.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ProductController(ApplicationDbContext context)
        {
            
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]   
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id)
        {
            Product? productToEdit = await _context.Product.FindAsync(id);

            if (productToEdit == null)
            {
                return NotFound();
            }

            return View(productToEdit);
        }

        public async Task<IActionResult> Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Product.Update(product);
                await _context.SaveChangesAsync();

                TempData["Message"] = $"{product.ProductIdProduct} was updated successfully";
                return RedirectToAction("Index");
            }
            return View(product);
        }
        
        public async Task<IActionResult> Delete(int id)
        {
            Product productToDelete = await _context.Product.FindAsync(id);

            if (productToDelete == null)
            {
                return NotFound();
            }
            return View(productToDelete);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Product productToDelete = await _context.Product.FindAsync(id);

            if(productToDelete != null)
            {
                _context.Product.Remove(productToDelete);
                await _context.SaveChangesAsync();
                TempData["Message"] = productToDelete.ProductIdProduct + " was deleted successfully";
                return RedirectToAction("Index");
            }

            TempData["Message"] = "This product has already been deleted";
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int id)
        {
            Product productDetails = await _context.Product.FindAsync(id);

            if (productDetails == null)
            {
                return NotFound();
            }

            return View(productDetails);
        }
    }
}
