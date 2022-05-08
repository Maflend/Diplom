namespace Diplom.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal PurchasePrice { get; set; }
        public Category Category { get; set; }
        public List<Sale> Sales { get; set; }
    }
}
