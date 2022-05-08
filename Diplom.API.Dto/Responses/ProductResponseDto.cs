namespace Diplom.API.Dto.Responses
{
    public class ProductResponseDto
    {
        public Guid Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal PurchasePrice { get; set; }
    }
}
