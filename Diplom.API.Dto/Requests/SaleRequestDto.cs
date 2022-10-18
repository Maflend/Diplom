namespace Diplom.API.Dto.Requests;

/// <summary>
/// Дто продажи.
/// </summary>
public class SaleRequestDto
{
    /// <summary>
    /// Количество товара к приобретению.
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Идентификатор продукта.
    /// </summary>
    public Guid ProductId { get; set; }
}
