using System;
using System.Collections.Generic;
using System.Text;
using WpfAppEfCoreDI.Domain.Entities;

namespace WpfAppEfCoreDI.Appliciation.Services
{
    public interface IProductService
    {
        Task<bool> CreateProductAsync(Product product);
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> GetProductByIdAsync(Guid id);
        Task<bool> DeleteProductAsync(Product product);
        Task<bool> UpdateProductAsync(Product product);
    }
}
