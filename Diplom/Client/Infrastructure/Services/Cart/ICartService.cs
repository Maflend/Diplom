using Diplom.API.Dto.Dtos;

namespace Diplom.Client.Infrastructure.Services.Cart
{
    public interface ICartService
    {
        Task<List<CartDto>> GetSalesAsync();
        Task<CartDto> GetSaleAsync(Guid productId);
        Task AddSaleAsync(CartDto sale);
        Task UpdateSaleAsync(CartDto sale);
        Task DeleteSaleAsync(Guid productId);
        Task Clear();
    }
}
