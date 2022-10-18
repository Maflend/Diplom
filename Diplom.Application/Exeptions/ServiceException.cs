namespace Diplom.Application.Exeptions;

/// <summary>
/// Сервис ошибок для медиатора.
/// </summary>
public class ServiceException : Exception
{
    /// <summary>
    /// Тип ошибки.
    /// </summary>
    public ServiceExceptionType ServiceExceptionType;

    public ServiceException(string message, ServiceExceptionType type) : base(message)
    {
        ServiceExceptionType = type;
    }
}
