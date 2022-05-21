using Diplom.API.Dto.Responses;
using System.Net.Http.Json;

namespace Diplom.Client.Infrastructure.Managers.CategoryManager
{
    public class CategoryManager : ICategoryManager
    {
        private readonly HttpClient _httpClient;

        public CategoryManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<CategoryResponseDto>> GetAll()
        {
            var response = await _httpClient.GetFromJsonAsync<List<CategoryResponseDto>>(Routes.CategoryEndpoints.GetAll);

            return response;
        }
    }
}
