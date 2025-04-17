using SupplyChainManagementSystem.Server.Models;

/*
 * This is from Listing 3 on the CODE Magazine article of March/April 2025
 */
namespace SupplyChainManagementSystem.Server.DataAccess
{
    public class ProductRepository : IProductRepository // In the article this class didn't reference IProductRepository (huh?)
    {
        private readonly ProductDbContext _productDbContext;

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

        public async Task<Product> GetProductByIdAsync(Guid Id)
        {
            return await Task.FromResult(_productDbContext.Products.FirstOrDefault(p => p.Product_Id == Id)); 
        }

        public Task UpdateAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
