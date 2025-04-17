using SupplyChainManagementSystem.Server.Models;

namespace SupplyChainManagementSystem.Server.DataAccess
{
    public interface ISupplierRepository
    {
        public Task<List<Supplier>> GetSuppliersAsync();    // In the article this method was called GetSuppliers
        public Task<Supplier> GetSupplierByIdAsync(int Id);
    }
}
