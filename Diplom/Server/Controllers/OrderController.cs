using AutoMapper;
using Diplom.API.Dto.Dtos;
using Diplom.API.Dto.Requests;
using Diplom.API.Dto.Responses;
using Diplom.Application.Abstracts.Mediator.Orders.Commands;
using Diplom.Application.Abstracts.Mediator.Orders.Queries;
using Diplom.Domain.Enums;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Diplom.Server.Controllers
{
    /// <summary>
    /// Контроллер для заказа.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public OrderController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        /// <summary>
        /// Получить заказы.
        /// </summary>
        [HttpGet]
        [Authorize(Roles = nameof(RoleEnum.Administrator))]
        public async Task<ActionResult<List<OrderWithSalesDto>>> GetOrders()
        {
            return await _mediator.Send(new GetOrdersQuery());
        }

        /// <summary>
        /// Создать заказ.
        /// </summary>
        /// <param name="sales">List<see cref="SaleRequestDto"/></param>
        [HttpPost("create")]
        [Authorize(Roles = nameof(RoleEnum.Client))]
        public async Task<ActionResult<OrderResponseDto>> CreateOrderAsync(List<SaleRequestDto> sales)
        {
            var claimsIdentity = this.User.Identity as ClaimsIdentity;
            var userName = claimsIdentity?.FindFirst(ClaimTypes.Name)?.Value;
            var createOrderCommand = new CreateOrderCommand()
            {
                Sales = _mapper.Map<List<CreateSaleDto>>(sales),
                UserName = userName
            };

            var order = await _mediator.Send(createOrderCommand);

            return Ok(order);
        }
    }
}
