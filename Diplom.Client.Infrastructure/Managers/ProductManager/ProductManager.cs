using Blazored.Toast.Services;
using Diplom.API.Dto.Responses;
using Diplom.Client.Infrastructure.Erros;
using Diplom.Client.Infrastructure.Services.Authentication;
using Diplom.Client.Infrastructure.Services.Http;
using Microsoft.AspNetCore.WebUtilities;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace Diplom.Client.Infrastructure.Managers.ProductManager
{
    public class ProductManager : IProductManager
    {
        private readonly HttpClient _httpClient;
        private readonly ITokenService _tokenService;
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductManager(HttpClient httpClient, ITokenService tokenService, IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClient;
            _tokenService = tokenService;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<List<ProductResponseDto>> GetAll()
        {
            var http = _httpClientFactory.CreateClient("ApiClient");
            var httpResponse = await http.GetAsync(Routes.ProductEndpoints.GetAll);
            var httpResponseMessageHelper = new HttpResponseMessageHelper<List<ProductResponseDto>>();
            var response = await httpResponseMessageHelper.GetFromHttpResponseMessageAsync(httpResponse);

            return response;
        }

        public async Task<List<ProductResponseDto>> GetByCategoryId(Guid categoryid)
        {
            var http = _httpClientFactory.CreateClient("ApiClient");
            var query = new Dictionary<string, string>()
            {
                ["categoryId"] = $"{categoryid}"
            };

            var uri = QueryHelpers.AddQueryString(Routes.ProductEndpoints.GetByCategoryId, query);
            var httpResponse = await http.GetAsync(uri);
            var httpResponseMessageHelper = new HttpResponseMessageHelper<List<ProductResponseDto>>();
            var response = await httpResponseMessageHelper.GetFromHttpResponseMessageAsync(httpResponse);

            return response;
        }

        public async Task<ProductResponseDto> GetById(Guid id)
        {
            var http = _httpClientFactory.CreateClient("ApiClient");
            var query = new Dictionary<string, string>()
            {
                ["Id"] = $"{id}"
            };

            var uri = QueryHelpers.AddQueryString(Routes.ProductEndpoints.GetById, query);
            var httpResponse = await http.GetAsync(uri);
            var httpResponseMessageHelper = new HttpResponseMessageHelper<ProductResponseDto>();
            var response = await httpResponseMessageHelper.GetFromHttpResponseMessageAsync(httpResponse);

            return response;
        }
    }
}
