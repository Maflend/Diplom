using Diplom.API.Dto.Dtos;
using Diplom.API.Dto.Responses;

namespace Diplom.Client.Infrastructure.Managers.OrderManager
{
    public interface IOrderManager
    {
        Task<OrderResponseDto> CreateOrderAsync(List<CartDto> Cart);
        Task<List<OrderWithSalesDto>> GetOrdersAsync();
    }
}
