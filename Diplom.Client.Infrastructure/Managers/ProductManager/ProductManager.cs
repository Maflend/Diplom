using Diplom.API.Dto.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Client.Infrastructure.Managers.ProductManager
{
    public class ProductManager : IProductManager
    {
        private readonly HttpClient _httpClient;

        public ProductManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<ProductResponseDto>> GetAll()
        {
            var response = await _httpClient.GetFromJsonAsync<List<ProductResponseDto>>(Routes.ProductEndpoints.GetAll);

            return response;
        }

        public Task<ProductResponseDto> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
