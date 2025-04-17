using Microsoft.EntityFrameworkCore;
using SupplyChainManagementSystem.Server.Models;
namespace SupplyChainManagementSystem.Server.DataAccess
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly SupplierDbContext _supplierDbContext;

        public SupplierRepository(SupplierDbContext supplierDbContext)
        {
            _supplierDbContext = supplierDbContext;
        }

        public async Task<List<Supplier>> GetSuppliersAsync()
        {
            return await _supplierDbContext.Suppliers.ToListAsync();
        }
        public async Task<Supplier> GetSupplierByIdAsync(Guid Id)
        {
            return await Task.FromResult(_supplierDbContext.Suppliers.FirstOrDefault(s => s.Id == Id));
        }
    }
}
