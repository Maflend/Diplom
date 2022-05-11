using Diplom.API.Dto.Responses;
using MediatR;

namespace Diplom.Application.Abstracts.Mediator.Orders.Commands
{
    public class CreateOrderCommand : IRequest<OrderResponseDto>
    {
        public int Quantity { get; set; }
        public Guid ProductId { get; set; }
    }
}
