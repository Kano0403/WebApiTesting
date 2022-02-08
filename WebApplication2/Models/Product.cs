namespace WebApplication2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
        public ICollection<ProductOwner> ProductOwners { get; set; }
    }
}
