namespace e_yama.Models
{
    public class Product
    {
        public int Id { get; set; } //pk
        public int CategoryId { get; set; } //fk
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
    }
}