namespace Diplom.Client.Infrastructure.Erros
{
    /// <summary>
    /// Exception для ответа сервера.
    /// </summary>
    public class HttpResponseException : Exception
    {
        public HttpResponseException()
        {
        }

        public HttpResponseException(string? message) : base(message)
        {

        }
    }
}
