using Diplom.API.Dto.Responses;

namespace Diplom.API.Dto.Dtos

{
    public class CartDto
    {
        public ProductResponseDto Product { get; set; }
        public int Quantity { get; set; }
    }
}
