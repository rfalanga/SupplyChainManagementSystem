using Microsoft.EntityFrameworkCore;
using SupplyChainManagementSystem.Models;

namespace SupplyChainManagementSystem.DataAccess
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Product> Products { get; set; } = default!;
    }
}
