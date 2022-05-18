using Diplom.API.Dto.Requests;
using Diplom.API.Dto.Responses;

namespace Diplom.Client.Infrastructure.Managers.OrderManager
{
    public interface IOrderManager
    {
        Task<OrderResponseDto> CreateOrderAsync(List<SaleRequestDto> sales);
    }
}
