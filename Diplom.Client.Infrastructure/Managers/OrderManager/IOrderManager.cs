using Diplom.API.Dto.Dtos;
using Diplom.API.Dto.Responses;

namespace Diplom.Client.Infrastructure.Managers.OrderManager
{
    /// <summary>
    /// Менеджера заказов.
    /// </summary>
    public interface IOrderManager
    {
        /// <summary>
        /// Запрос на создание заказа.
        /// </summary>
        /// <param name="Cart">Корзина товаров.</param>
        Task<OrderResponseDto> CreateOrderAsync(List<CartDto> Cart);

        /// <summary>
        /// Запрос на получение заказов.
        /// </summary>
        Task<List<OrderWithSalesDto>> GetOrdersAsync();
    }
}
