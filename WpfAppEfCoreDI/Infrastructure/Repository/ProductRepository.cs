using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WpfAppEfCoreDI.Domain.Entities;
using WpfAppEfCoreDI.Domain.Repository;
using WpfAppEfCoreDI.Infrastructure.Data;

namespace WpfAppEfCoreDI.Infrastructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddAsync(Product product)
        {
            try
            {
                await _context.Products.AddAsync(product);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(Product product)
        {
            try
            {
                await _context.Products
                    .Where(p => p.ID == product.ID)
                    .ExecuteUpdateAsync(setters => setters
                        .SetProperty(p => p.IsDeleted, true)
                    );
                return true;
            }
            catch (Exception ex )
            {
                return false;
            }
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            try
            {
                var products = await _context.Products
                    .AsNoTracking()
                    .ToArrayAsync();
                return products;
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<Product>();
            }

        }

        public async Task<Product> GetByIdAsync(Guid id)
        {
            try
            {
                var product = await _context.Products.FindAsync(id);
                return product;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Task<bool> UpdateAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
