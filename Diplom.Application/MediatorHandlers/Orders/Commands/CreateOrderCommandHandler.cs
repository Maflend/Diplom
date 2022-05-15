using AutoMapper;
using Diplom.API.Dto.Responses;
using Diplom.Application.Abstracts.Mediator.Orders.Commands;
using Diplom.Domain.Entities;
using Diplom.Domain.Repositories.Abstracts;
using Diplom.Infrastructure.Specifications.UserSpecifications;
using MediatR;

namespace Diplom.Application.MediatorHandlers.Orders.Commands
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, OrderResponseDto>
    {
        private readonly IMapper _mapper;
        private readonly IOrderRepository _orderRepository;
        private readonly IUserRepository _userRepository;

        public CreateOrderCommandHandler(
            IMapper mapper,
            IOrderRepository orderRepository,
            IUserRepository userRepository
            )
        {
            _mapper = mapper;
            _orderRepository = orderRepository;
            _userRepository = userRepository;
        }
        public async Task<OrderResponseDto> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = new Order()
            {
                CreateDate = DateTime.Now,
                Sales = _mapper.Map<List<Sale>>(request.Sales),
                User = await _userRepository.GetBySpecAsync(new GetUserSpec(request.UserName), cancellationToken)
            };

            await _orderRepository.AddAndSaveAsync(order, cancellationToken);

            return _mapper.Map<OrderResponseDto>(order);
        }
    }
}
