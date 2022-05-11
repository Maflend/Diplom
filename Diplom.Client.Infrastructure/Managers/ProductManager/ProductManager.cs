using Diplom.API.Dto.Responses;
using Diplom.Client.Infrastructure.Services.Authentication;
using Microsoft.AspNetCore.WebUtilities;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace Diplom.Client.Infrastructure.Managers.ProductManager
{
    public class ProductManager : IProductManager
    {
        private readonly HttpClient _httpClient;
        private readonly ITokenService _tokenService;

        public ProductManager(HttpClient httpClient, ITokenService tokenService)
        {
            _httpClient = httpClient;
            _tokenService = tokenService;
        }
        public async Task<List<ProductResponseDto>> GetAll()
        {
            var token = await _tokenService.GetTokenAsync();
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.GetFromJsonAsync<List<ProductResponseDto>>(Routes.ProductEndpoints.GetAll);

            return response;
        }

        public async Task<List<ProductResponseDto>> GetByCategoryId(Guid categoryid)
        {
            var query = new Dictionary<string, string>()
            {
                ["categoryId"] = $"{categoryid}"
            };

            var uri = QueryHelpers.AddQueryString(Routes.ProductEndpoints.GetByCategoryId, query);
            var response = await _httpClient.GetFromJsonAsync<List<ProductResponseDto>>(uri);

            return response;
        }

        public async Task<ProductResponseDto> GetById(Guid id)
        {
            var query = new Dictionary<string, string>()
            {
                ["Id"] = $"{id}"
            };

            var uri = QueryHelpers.AddQueryString(Routes.ProductEndpoints.GetById, query);
            var response = await _httpClient.GetFromJsonAsync<ProductResponseDto>(uri);

            return response;
        }
    }
}
