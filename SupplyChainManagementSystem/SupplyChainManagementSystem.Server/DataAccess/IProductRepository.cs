using SupplyChainManagementSystem.Server.Models;    // In the article this was SupplyChainManagementSystem.Shared.Models

namespace SupplyChainManagementSystem.Server.DataAccess
{
    public interface IProductRepository
    {
        public Task<List<Product>> GetAllProductsAsync();
        public Task<Product> GetProductByIdAsync(Guid id);
        public Task CreateAsync(Product product);
        public Task UpdateAsync(Product product);
        public Task DeleteAsync(Product product);
    }
}
