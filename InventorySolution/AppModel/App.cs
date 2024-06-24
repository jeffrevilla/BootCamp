using InventorySolution.Models;

namespace InventorySolution.AppModels
{
    public class App
    {
        public IEnumerable<Product> Products { get; set; }
        public Product NewProduct { get; set; }
    }
}