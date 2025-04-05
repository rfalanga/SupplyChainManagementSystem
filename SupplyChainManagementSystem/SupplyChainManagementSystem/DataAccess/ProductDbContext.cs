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
    }
}
