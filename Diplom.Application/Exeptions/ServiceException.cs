namespace Diplom.Application.Exeptions
{
    public class ServiceException : Exception
    {
        public ServiceExceptionType ServiceExceptionType;
        public ServiceException(string message, ServiceExceptionType type) : base(message)
        {
            ServiceExceptionType = type;
        }
    }
}
