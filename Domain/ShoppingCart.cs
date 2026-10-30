namespace ECommerceApp.Domain
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public DateTime AddedDate { get; set; }


        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public Customer Customer { get; set; }
        public Product Product { get; set; }
    }
}
