namespace Diplom.API.Dto.Responses;

/// <summary>
/// Dto продукта для ответа сервера.
/// </summary>
public class ProductResponseDto
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Наименование.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Описание
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// URL изображения.
    /// </summary>
    public string ImgUrl { get; set; }

    /// <summary>
    /// Цена.
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Закупочная цена.
    /// </summary>
    public decimal PurchasePrice { get; set; }
}
