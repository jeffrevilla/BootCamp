using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using ProductsSolution.Models;

namespace ProductsSolution.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}