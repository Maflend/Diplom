namespace Diplom.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public decimal Price { get; set; }
        public decimal PurchasePrice { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
