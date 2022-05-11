using Diplom.API.Dto.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

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

        public Task<CategoryResponseDto> GetById()
        {
            throw new NotImplementedException();
        }
    }
}
