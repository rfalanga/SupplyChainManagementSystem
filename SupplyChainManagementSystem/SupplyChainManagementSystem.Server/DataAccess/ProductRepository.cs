﻿using SupplyChainManagementSystem.Server.Models;

namespace SupplyChainManagementSystem.Server.DataAccess
{
    public class ProductRepository : IProductRepository
    {
        private readonly object _productDbContext;

        public ProductRepository(ProductDbContext productDbContext)
        {
            _productDbContext = productDbContext;
        }
        // The constructor is not used in the article, but it is a good practice to have it

        public async Task<List<Product>> GetAllProductsAsync()  // In the article this method was named GetProducts()
        {
            // This method is not in the Interface, but it is a good practice to have it
            return await Task.FromResult(_productDbContext.Products.ToList());
        }

        public Task CreateAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
