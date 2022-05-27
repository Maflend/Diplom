using Diplom.Client.Infrastructure.Services.Authentication;
using System.Net.Http.Headers;

namespace Diplom.Client.Infrastructure.Authentication
{
    /// <summary>
    /// Обработчки Http-запросов для установления заголовка JWT.
    /// </summary>
    public class AuthenticationHeaderHandle : DelegatingHandler
    {
        private readonly ITokenService _tokenService;

        public AuthenticationHeaderHandle(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }

        protected async override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            var token = await _tokenService.GetTokenAsync();

            if(token != null && !string.IsNullOrWhiteSpace(token))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
          
            return await base.SendAsync(request, cancellationToken);
        }
    }
}
