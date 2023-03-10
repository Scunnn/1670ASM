namespace AsmFinal.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public virtual ICollection<Order>? Order { get; set; }
        public virtual ICollection<Category>? Categories { get; set; }
    }
}
