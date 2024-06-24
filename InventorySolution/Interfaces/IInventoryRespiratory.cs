using System.Collections.Generic;
using System.Threading.Tasks;
using InventorySolution.Models;

namespace InventorySolution.interfaces
{
    public interface IInventoryRespiratory
    {
        Task<IEnumerable<Product>> GetAllProducts();

        Task AddProduct(Product product);

        Task DeleteProduct (int id);
    }
}