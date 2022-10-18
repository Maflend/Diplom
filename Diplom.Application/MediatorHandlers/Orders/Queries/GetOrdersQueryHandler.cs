using AutoMapper;
using Diplom.API.Dto.Responses;
using Diplom.Application.Abstracts.Mediator.Orders.Queries;
using Diplom.Domain.Repositories.Abstracts;
using Diplom.Domain.Specifications.OrderSpecifications;
using MediatR;

namespace Diplom.Application.MediatorHandlers.Orders.Queries;

/// <summary>
/// Хендлер запроса получения всех заказов.
/// </summary>
public class GetOrdersQueryHandler : IRequestHandler<GetOrdersQuery, List<OrderWithSalesDto>>
{
    private readonly IOrderRepository _orderRepository;
    private readonly IMapper _mapper;

    public GetOrdersQueryHandler(IOrderRepository orderRepository, IMapper mapper)
    {
        _orderRepository = orderRepository;
        _mapper = mapper;
    }

    /// <inheritdoc cref="GetOrdersQueryHandler"/>
    public async Task<List<OrderWithSalesDto>> Handle(GetOrdersQuery request, CancellationToken cancellationToken)
    {
        return _mapper.Map<List<OrderWithSalesDto>>(await _orderRepository.GetAllBySpecAsync(new GetOrdersWithSalesSpec(), cancellationToken));
    }
}
