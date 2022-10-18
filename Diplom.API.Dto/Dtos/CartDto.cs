using Diplom.API.Dto.Responses;

namespace Diplom.API.Dto.Dtos;

/// <summary>
/// Дто корзины.
/// </summary>
public class CartDto
{
    /// <summary>
    /// Продукт.
    /// </summary>
    public ProductResponseDto Product { get; set; }

    /// <summary>
    /// Количество к приобретению.
    /// </summary>
    public int Quantity { get; set; }
}
