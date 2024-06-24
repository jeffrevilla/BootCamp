using System.Collections.Generic;
using System.Threading.Tasks;
using ProductsSolution.Models;

namespace ProductsSolution.Interfaces
{
    public interface IProductRespiratory
    {
        Task<IEnumerable<Product>> GetAllProducts();

        Task AddProduct(Product product);

        Task DeleteProduct(int id);                             
    }
}