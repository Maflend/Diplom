namespace Diplom.API.Dto.Responses;

/// <summary>
/// Dto категории для ответа сервера.
/// </summary>
public class CategoryResponseDto
{
    /// <summary>
    /// Уникальный идентификатор.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Наименование.
    /// </summary>
    public string Name { get; set; }
}
