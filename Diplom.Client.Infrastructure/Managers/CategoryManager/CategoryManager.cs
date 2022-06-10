using Diplom.API.Dto.Responses;
using Diplom.Client.Infrastructure.Services.Http;

namespace Diplom.Client.Infrastructure.Managers.CategoryManager
{
    /// <summary>
    /// Менеджер для контроллера категорий.
    /// </summary>
    public class CategoryManager : ICategoryManager
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CategoryManager(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        /// <summary>
        /// Запрос получения всех категорий.
        /// </summary>
        /// <returns></returns>
        public async Task<List<CategoryResponseDto>> GetAll()
        {
            var http = _httpClientFactory.CreateClient("ApiClient");
            var httpResponse = await http.GetAsync(Routes.CategoryEndpoints.GetAll);
            var httpResponseMessageHelper = new HttpResponseMessageHelper<List<CategoryResponseDto>>();
            var response = await httpResponseMessageHelper.GetFromHttpResponseMessageAsync(httpResponse);

            return response;
        }
    }
}
