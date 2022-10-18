using Diplom.Domain.Entities.Base;

namespace Diplom.Domain.Entities;

/// <summary>
/// Продукт.
/// </summary>
public class Product : BaseEntity
{
    /// <summary>
    /// Наименование.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Описание.
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

    /// <summary>
    /// Идентификатор категории.
    /// </summary>
    public Guid CategoryId { get; set; }

    /// <summary>
    /// Категория.
    /// </summary>
    public Category Category { get; set; }
}
