namespace Diplom.API.Dto.Responses;

/// <summary>
/// Dto продажи.
/// </summary>
public class SaleResponseDto
{
    /// <summary>
    /// Количество.
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Идентификатор продукта.
    /// </summary>
    public Guid ProductId { get; set; }
}
