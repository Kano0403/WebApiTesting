namespace WebApplication2.Models
{
    public class ProductOwner
    {
        public int ProductId { get; set; }
        public int OwnerId { get; set; }
        public Product Product { get; set; }
        public Owner Owner { get; set; }
    }
}
