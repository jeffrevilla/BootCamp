using Microsoft.EntityFrameworkCore;
using InventorySolution.Models;

namespace InventorySolution.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base (options){}

        public DbSet<Product> Products {get; set;}
    }
}