using System;
using System.Collections.Generic;
using System.Text;
using WpfAppEfCoreDI.Domain.Entities;

namespace WpfAppEfCoreDI.Domain.Repository
{
    public interface IProductRepository
    {
        Task<bool> AddAsync(Product product);
        Task<bool> UpdateAsync(Product product);
        Task<bool> DeleteAsync(Product product);
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(Guid id);
    }
}
