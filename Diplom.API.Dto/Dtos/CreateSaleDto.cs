namespace Diplom.API.Dto.Dtos;

/// <summary>
/// Дто создания продажи.
/// </summary>
public class CreateSaleDto
{
    /// <summary>
    /// Количество к приобретению.
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Идентификатор продукта.
    /// </summary>
    public Guid ProductId { get; set; }
}
