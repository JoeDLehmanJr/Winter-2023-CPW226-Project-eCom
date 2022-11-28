using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CPW221_Project_eCom.Models;

namespace CPW221_Project_eCom.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<CustomerLogin> CustomerLogin { get; set; }
        
        public DbSet<InvoicedItems> InvoicedItems { get; set; }

        public DbSet<Product> Product { get; set; }

        public DbSet<Invoices> Invoices { get; set; }
    }
}