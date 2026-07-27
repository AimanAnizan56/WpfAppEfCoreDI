using System;
using System.Collections.Generic;
using System.Text;
using WpfAppEfCoreDI.Domain.Entities;
using WpfAppEfCoreDI.Domain.Repository;

namespace WpfAppEfCoreDI.Appliciation.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<bool> CreateProductAsync(Product product)
        {
            return await _productRepository.AddAsync(product);
        }

        public Task<bool> DeleteProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllAsync();
        }

        public async Task<Product> GetProductByIdAsync(Guid id)
        {
            return await _productRepository.GetByIdAsync(id);
        }

        public Task<bool> UpdateProductAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
