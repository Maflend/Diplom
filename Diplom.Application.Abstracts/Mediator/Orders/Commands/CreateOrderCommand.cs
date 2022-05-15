using Diplom.API.Dto.Dtos;
using Diplom.API.Dto.Responses;
using MediatR;

namespace Diplom.Application.Abstracts.Mediator.Orders.Commands
{
    public class CreateOrderCommand : IRequest<OrderResponseDto>
    {
        public List<CreateSaleDto> Sales { get; set; }
        public string UserName { get; set; }
    }
}
