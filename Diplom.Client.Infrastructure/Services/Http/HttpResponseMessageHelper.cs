using Diplom.API.Dto;
using Diplom.Client.Infrastructure.Erros;
using System.Net.Http.Json;

namespace Diplom.Client.Infrastructure.Services.Http
{
    /// <summary>
    /// Вспомогательный класс для чтения данных из ответа сервера в формате Json.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class HttpResponseMessageHelper<T>
    {
        /// <summary>
        /// Получить данные ответа в формате Json.
        /// </summary>
        /// <param name="httpResponse"><see cref="HttpResponseMessage"/></param>
        /// <returns><see cref="T"/></returns>
        /// <exception cref="HttpResponseException"></exception>
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
