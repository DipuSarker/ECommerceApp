namespace ECommerceApp.Domain
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }

        // Relationship : One Category can have many Products
        //public List<Product> Products { get; set; }
    }
}
