using Diplom.API.Dto.Responses;
using System.Net.Http.Json;

namespace Diplom.Client.Infrastructure.Managers.CategoryManager
{
    /// <summary>
    /// Менеджер для контроллера категорий.
    /// </summary>
    public class CategoryManager : ICategoryManager
    {
        private readonly HttpClient _httpClient;

        public CategoryManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Запрос получения всех категорий.
        /// </summary>
        /// <returns></returns>
        public async Task<List<CategoryResponseDto>> GetAll()
        {
            var response = await _httpClient.GetFromJsonAsync<List<CategoryResponseDto>>(Routes.CategoryEndpoints.GetAll);

            return response;
        }
    }
}
