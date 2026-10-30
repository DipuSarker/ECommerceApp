namespace ECommerceApp.Domain
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; }

        // Relationship : Customer can have many Orders
        public ICollection<Order> Orders { get; set; } = new List<Order>();

        // Relationship : Customer can have many ShoppingCart Items
        public ICollection<ShoppingCart> ShoppingCarts { get; set; } = new List<ShoppingCart>();



    }
}
