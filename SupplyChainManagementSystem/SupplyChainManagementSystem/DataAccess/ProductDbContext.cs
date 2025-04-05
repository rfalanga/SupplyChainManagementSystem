using Bogus;
using Microsoft.EntityFrameworkCore;
using SupplyChainManagementSystem.Models;

namespace SupplyChainManagementSystem.DataAccess
{
    public class ProductDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public ProductDbContext(DbContextOptions<ProductDbContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Product> Products { get; set; } = default!;
        private Product[] GenerateProductData()
        {
            var productFaker = new Faker<Product>()
                .RuleFor(p => p.Product_Id, f => Guid.NewGuid())
                .RuleFor(p => p.Product_Name, f => f.Commerce.ProductName())
                .RuleFor(p => p.Product_Description, f => f.Lorem.Sentence(10))
                .RuleFor(p => p.Product_Category, f => f.Commerce.Categories(1)[0])
                .RuleFor(p => p.Product_Price, f => decimal.Parse(f.Commerce.Price(1, 1000)))
                .RuleFor(p => p.Product_Quantity, f => f.Random.Int(1, 100))
                .RuleFor(p => p.Created_At, f => DateTime.Now);
        }
    }

}
