using Diplom.Application.Exeptions;
using System.Net;
using System.Text.Json;

namespace Diplom.Server
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (ServiceException error)
            {
                var response = context.Response;
                response.ContentType = "application/json";

                switch (error.ServiceExceptionType)
                {
                    case ServiceExceptionType.NotFound:
                        response.StatusCode = (int)HttpStatusCode.NotFound;
                        break;
                    case ServiceExceptionType.BadRequest:
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        break;
                    default:
                        response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        break;
                }
                var result = JsonSerializer.Serialize(new { message = error?.Message });
                await response.WriteAsync(result);
            }
        }
    }
}
