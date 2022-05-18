namespace Diplom.Client.Infrastructure.Erros
{
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
