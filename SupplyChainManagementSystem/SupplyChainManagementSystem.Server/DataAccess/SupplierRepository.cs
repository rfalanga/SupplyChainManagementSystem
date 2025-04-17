namespace SupplyChainManagementSystem.Server.DataAccess
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly SupplyChainDbContext _context;
        public SupplierRepository(SupplyChainDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Supplier>> GetAllSuppliersAsync()
        {
            return await _context.Suppliers.ToListAsync();
        }
        public async Task<Supplier> GetSupplierByIdAsync(int id)
        {
            return await _context.Suppliers.FindAsync(id);
        }
        public async Task AddSupplierAsync(Supplier supplier)
        {
            await _context.Suppliers.AddAsync(supplier);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateSupplierAsync(Supplier supplier)
        {
            _context.Suppliers.Update(supplier);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteSupplierAsync(int id)
        {
            var supplier = await GetSupplierByIdAsync(id);
            if (supplier != null)
            {
                _context.Suppliers.Remove(supplier);
                await _context.SaveChangesAsync();
            }
        }
    }
    {
    }
}
