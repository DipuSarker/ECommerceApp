namespace ECommerceApp.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string SKU { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        // Relationship : Product belongs to a Category
        public Category Category { get; set; }
        public Inventory Inventory { get; set; }
        public int CategoryId { get; set; }

        // Relationship : Customer can have many ShoppingCart Items
        public ICollection<ShoppingCart> ShoppingCarts { get; set; } = new List<ShoppingCart>();

        // Relationship : Customer can have many OrderItem
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    }
}
