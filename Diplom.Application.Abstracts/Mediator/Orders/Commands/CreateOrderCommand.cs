using Diplom.API.Dto.Dtos;
using Diplom.API.Dto.Responses;
using MediatR;

namespace Diplom.Application.Abstracts.Mediator.Orders.Commands;

/// <summary>
/// Команда создания заказа.
/// </summary>
public class CreateOrderCommand : IRequest<OrderResponseDto>
{
    /// <summary>
    /// Лист продаж.
    /// </summary>
    public List<CreateSaleDto> Sales { get; set; }

    /// <summary>
    /// Имя пользователя.
    /// </summary>
    public string UserName { get; set; }
}
