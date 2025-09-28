using ProductService.Models;

namespace ProductService.Services;

using System.Collections.Generic;
using System.Threading.Tasks;

public interface IProductService
{
    Task<IEnumerable<Product>> GetAllAsync();
    Task<Product?> GetByIdAsync(long id);
    Task<Product> CreateAsync(Product product);
    Task<Product?> UpdateAsync(long id, Product product);
    Task<bool> DeleteAsync(long id);
}
