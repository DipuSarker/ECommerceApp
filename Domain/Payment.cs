namespace ECommerceApp.Domain
{
    public class Payment
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PayDate { get; set; }
        public string TransId { get; set; }

        public Order Order { get; set; }
    }
}
