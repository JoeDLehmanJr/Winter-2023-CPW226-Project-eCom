using Microsoft.AspNetCore.Mvc;
using CPW221_Project_eCom.Models;
using CPW221_Project_eCom.Data;
using Microsoft.EntityFrameworkCore;

namespace CPW221_Project_eCom.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ProductController(ApplicationDbContext context)
        {
            
            _context = context;
        }
        

        public async Task<IActionResult> Index(int? id)
        {
            const int NUMBEROFSOFTWARETODISPLAY = 10;

            // Need a page offset to use current page and figure out, number of software programs to skip
            const int PageOffset = 1;

            // Set currPage to id if it has a value, otherwise use 1
            int currPage = id ?? 1;

            int totalNumberOfProducts = await _context.Product.CountAsync();
            double MaxNumberOfPages = Math.Ceiling((double)totalNumberOfProducts / NUMBEROFSOFTWARETODISPLAY);

            // Rounding pages up, to next whole page number
            int lastPage = Convert.ToInt32(MaxNumberOfPages);

            //Get all Products from the DB (Query Syntax)
            List<Product> products = await(from product in _context.Product select product)
                .Skip(NUMBEROFSOFTWARETODISPLAY * (currPage - PageOffset))
                .Take(NUMBEROFSOFTWARETODISPLAY)
                .ToListAsync();
            
            return View(products);
        }
        

        [HttpGet]   
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {

            if (ModelState.IsValid)
            {
                _context.Product.Add(product);
                await _context.SaveChangesAsync();
                TempData["Message"] = $"{product.Title} was added successfully";
                return View();
            }
            return View(product);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            Product? productToEdit = await _context.Product.FindAsync(id);
            if (productToEdit == null)
            {
                return NotFound();
            }
            return View(productToEdit);
        }
        [HttpPost]
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
