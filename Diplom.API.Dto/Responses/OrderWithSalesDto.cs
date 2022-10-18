namespace Diplom.API.Dto.Responses;

/// <summary>
/// Dto заказа с продажами.
/// </summary>
public class OrderWithSalesDto
{
    /// <summary>
    /// Идентификатор заказа.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Дата создания заказа.
    /// </summary>
    public DateTime CreateDate { get; set; }

    /// <summary>
    /// Продажи.
    /// </summary>
    public int SalesCount { get; set; }
}
