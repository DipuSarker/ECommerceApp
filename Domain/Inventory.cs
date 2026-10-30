namespace ECommerceApp.Domain
{
    public class Inventory
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int StockQty { get; set; }
        public int ReorderLvl { get; set; }
        public DateTime LastUpdated { get; set; }

        public Product Product { get; set; }
    }
}
