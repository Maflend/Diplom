using Diplom.API.Dto.Responses;
using MediatR;

namespace Diplom.Application.Abstracts.Mediator.Orders.Queries
{
    /// <summary>
    /// Запрос получения всех заказов.
    /// </summary>
    public record GetOrdersQuery : IRequest<List<OrderWithSalesDto>>;
}
