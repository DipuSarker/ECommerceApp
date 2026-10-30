namespace ECommerceApp.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
        public string ShipAddress { get; set; }

        public Customer Customer { get; set; }
        public Payment Payment { get; set; }

        // Relationship : Customer can have many OrderItem
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
