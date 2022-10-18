namespace Diplom.Domain.Entities.Base;

/// <summary>
/// Базовая сущность.
/// </summary>
public class BaseEntity
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();
}
