using Diplom.API.Dto.Requests;
using Diplom.API.Dto.Responses;
using Diplom.Client.Infrastructure.Services.Http;
using System.Net.Http.Json;

namespace Diplom.Client.Infrastructure.Managers.OrderManager
{
    public class OrderManager : IOrderManager
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public OrderManager(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<OrderResponseDto> CreateOrderAsync(List<SaleRequestDto> sales)
        {
            var http = _httpClientFactory.CreateClient("ApiClient");
            var httpResponse = await http.PostAsJsonAsync(Routes.OrderEndpoints.CreateOrder, sales);
            var httpResponseMessageHelper = new HttpResponseMessageHelper<OrderResponseDto>();
            var response = await httpResponseMessageHelper.GetFromHttpResponseMessageAsync(httpResponse);

            return response;
        }
    }
}
