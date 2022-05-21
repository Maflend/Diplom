using Diplom.API.Dto;
using Diplom.Client.Infrastructure.Erros;
using System.Net.Http.Json;

namespace Diplom.Client.Infrastructure.Services.Http
{
    public class HttpResponseMessageHelper<T>
    {
        public async Task<T> GetFromHttpResponseMessageAsync(HttpResponseMessage httpResponse)
        {
            if (!httpResponse.IsSuccessStatusCode)
            {
                var responseError = await httpResponse.Content.ReadFromJsonAsync<ServerResponseError>();
                throw new HttpResponseException(responseError?.Message);
            }

            var response = await httpResponse.Content.ReadFromJsonAsync<T>();

            return response;
        }
    }
}
