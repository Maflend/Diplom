using AutoMapper;
using Diplom.API.Dto.Responses;
using Diplom.Application.Abstracts.Mediator.Orders.Commands;
using Diplom.Domain.Entities;
using Diplom.Domain.Repositories.Abstracts;
using Diplom.Domain.Specifications.UserSpecifications;
using MediatR;
using System.Text;

namespace Diplom.Application.MediatorHandlers.Orders.Commands;

/// <summary>
/// Обработчик создания заказа.
/// </summary>
public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, OrderResponseDto>
{
    private readonly IMapper _mapper;
    private readonly IOrderRepository _orderRepository;
    private readonly IUserRepository _userRepository;
    private readonly IProductRepository _productRepository;

    private readonly string _path = "D:\\Orders";

    public CreateOrderCommandHandler(
        IMapper mapper,
        IOrderRepository orderRepository,
        IUserRepository userRepository,
        IProductRepository productRepository
        )
    {
        _mapper = mapper;
        _orderRepository = orderRepository;
        _userRepository = userRepository;
        _productRepository = productRepository;
    }

    /// <summary>
    /// Метод обработки.
    /// </summary>
    /// <param name="request"><see cref="CreateOrderCommand"/></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<OrderResponseDto> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        var order = new Order()
        {
            CreateDate = DateTime.UtcNow,
            Sales = _mapper.Map<List<Sale>>(request.Sales),
            User = await _userRepository.GetBySpecAsync(new GetUserSpec(request.UserName), cancellationToken)
        };

        await _orderRepository.AddAndSaveAsync(order, cancellationToken);

        var orderResponse = _mapper.Map<OrderResponseDto>(order);

        var orderFileInfo = $"" +
            $"Дата создания: {orderResponse.CreateDate} \t Номер заказа: {orderResponse.Id} \n \n" +
            $"Товары: \n";

        decimal orderPrice = 0;


        foreach (var sale in request.Sales)
        {
            var product = await _productRepository.GetByIdAsync(sale.ProductId, cancellationToken);

            orderPrice += product.Price * sale.Quantity;

            orderFileInfo += $"Наименование: {product.Name} \t Кол-во: {sale.Quantity} \t Цена за штуку: {product.Price} \n";
        }


        orderFileInfo += $"\n\nИтого: {orderPrice}руб";

        var hasDirectory = Directory.Exists(_path);

        if (!hasDirectory)
        {
            Directory.CreateDirectory(_path);
        }

        var filePath = $"{_path}\\{order.Id}.txt";


        using (FileStream fstream = new FileStream(filePath, FileMode.OpenOrCreate))
        {
            byte[] buffer = Encoding.Default.GetBytes(orderFileInfo);

            await fstream.WriteAsync(buffer, 0, buffer.Length);
        }

        return orderResponse;
    }
}
