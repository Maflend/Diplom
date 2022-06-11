using AutoMapper;
using Diplom.API.Dto.Dtos;
using Diplom.API.Dto.Requests;
using Diplom.API.Dto.Responses;
using Diplom.Client.Infrastructure.Services.Http;
using System.Net.Http.Json;

namespace Diplom.Client.Infrastructure.Managers.OrderManager
{
    /// <summary>
    /// Менеджер для контроллера заказов.
    /// </summary>
    public class OrderManager : IOrderManager
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IMapper _mapper;

        public OrderManager(IHttpClientFactory httpClientFactory, IMapper mapper)
        {
            _httpClientFactory = httpClientFactory;
            _mapper = mapper;
        }

        /// <summary>
        /// Запрос на создание заказа.
        /// </summary>
        /// <param name="cart"></param>
        public async Task<OrderResponseDto> CreateOrderAsync(List<CartDto> cart)
        {
            var http = _httpClientFactory.CreateClient("ApiClient");
            var httpResponse = await http.PostAsJsonAsync(Routes.OrderEndpoints.CreateOrder, _mapper.Map<List<SaleRequestDto>>(cart));
            var httpResponseMessageHelper = new HttpResponseMessageHelper<OrderResponseDto>();
            var response = await httpResponseMessageHelper.GetFromHttpResponseMessageAsync(httpResponse);

            return response;
        }

        /// <summary>
        /// Запрос на получения заказов.
        /// </summary>
        public async Task<List<OrderWithSalesDto>> GetOrdersAsync()
        {
            var http = _httpClientFactory.CreateClient("ApiClient");
            var httpResponse = await http.GetAsync(Routes.OrderEndpoints.GetOrders);
            var httpResponseMessageHelper = new HttpResponseMessageHelper<List<OrderWithSalesDto>>();
            var response = await httpResponseMessageHelper.GetFromHttpResponseMessageAsync(httpResponse);

            return response;
        }
    }
}
