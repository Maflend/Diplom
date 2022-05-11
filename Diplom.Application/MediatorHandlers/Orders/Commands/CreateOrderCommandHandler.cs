using AutoMapper;
using Diplom.API.Dto.Responses;
using Diplom.Application.Abstracts.Mediator.Orders.Commands;
using Diplom.Domain.Entities;
using Diplom.Domain.Repositories.Abstracts;
using MediatR;
using System.Security.Claims;

namespace Diplom.Application.MediatorHandlers.Orders.Commands
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, OrderResponseDto>
    {
        private readonly IMapper _mapper;
        private readonly IOrderRepository _orderRepository;

        public CreateOrderCommandHandler(IMapper mapper, IOrderRepository orderRepository)
        {
            _mapper = mapper;
            _orderRepository = orderRepository;
        }
        public async Task<OrderResponseDto> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            Order order = new Order()
            {
               
        };
           


            throw new NotImplementedException();
        }
    }
}
