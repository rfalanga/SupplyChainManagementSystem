using Bogus;
using Microsoft.EntityFrameworkCore;
using SupplyChainManagementSystem.Server.Models;

namespace SupplyChainManagementSystem.Server.DataAccess
{
    // Listing 5
    public class SupplierDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public SupplierDbContext(DbContextOptions<SupplierDbContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _ = optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")).EnableSensitiveDataLogging();
        }

        public DbSet<Supplier> Suppliers { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Supplier>().ToTable("Supplier");
            modelBuilder.Entity<Supplier>().HasKey(s => s.Id);
            var suppliers = GenerateSupplierData();
            modelBuilder.Entity<Supplier>().HasData(suppliers);
        }

        private static Supplier[] GenerateSupplierData()
        {
            var supplierFaker = new Faker<Supplier>()
                .RuleFor(s => s.Id, f => Guid.NewGuid())
                .RuleFor(s => s.FirstName, f => f.Person.FullName)
                .RuleFor(s => s.LastName, f => f.Person.FullName)   // this wasn't in the article, but I thought I'd put it in
                .RuleFor(s => s.Phone, f => f.Phone.PhoneNumber())
                .RuleFor(s => s.Email, f => f.Internet.Email()) // this was suggested by GH Copilot
                .RuleFor(s => s.Address, f => f.Address.FullAddress());

            return supplierFaker.Generate(count: 5).ToArray();
        }
    }
}
