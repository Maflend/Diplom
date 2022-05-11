namespace Diplom.API.Dto.Responses
{
    public class OrderResponseDto
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public SaleResponseDto Sales { get; set; }
    }
}
