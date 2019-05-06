namespace e_yama.Models
{
    public class Tag
    {
        public int Id { get; set; } //pk
        public int ProductId { get; set; } //fk
        public string TagName { get; set; }
    }
}