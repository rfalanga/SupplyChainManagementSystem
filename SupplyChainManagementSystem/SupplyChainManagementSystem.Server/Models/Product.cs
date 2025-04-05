namespace SupplyChainManagementSystem.Server.Models
{
    public record Product
    {
        public Guid Product_Id { get; set; }
        public string Product_Name { get; set; } = default!;
        public string Product_Description { get; set; } = default!;
        public string Product_Category { get; set; } = default!;
        public decimal Product_Price { get; set; } = default!;
        public int Product_Quantity { get; set; } = default!;
        public DateTime Created_At { get; set; } = DateTime.Now;
    }
}
