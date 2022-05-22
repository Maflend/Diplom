using Microsoft.AspNetCore.Components;
using System.Net;

namespace Diplom.Client.Infrastructure.Services.Http
{
    /// <summary>
    /// Обработчки Http-ответов для реагирования на Http-код.
    /// </summary>
    public class HttpPipeline : DelegatingHandler
    {
        private readonly NavigationManager _navigationManager;

        public HttpPipeline(NavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
        }

        protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var response = await base.SendAsync(request, cancellationToken);
            var statusCode = response.StatusCode;

            if(statusCode == HttpStatusCode.OK || statusCode == HttpStatusCode.NoContent)
            {
                return response;
            }

            switch (statusCode)
            {
                case HttpStatusCode.NotFound:
                    _navigationManager.NavigateTo("/404");
                    break;
                case HttpStatusCode.Unauthorized:
                    _navigationManager.NavigateTo("/unauthorized");
                    break;
                default:
                    _navigationManager.NavigateTo("/500");
                    break;
            }

            return response;
        }
    }
}
