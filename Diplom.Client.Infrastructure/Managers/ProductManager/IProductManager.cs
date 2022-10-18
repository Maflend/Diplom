using Diplom.API.Dto.Responses;

namespace Diplom.Client.Infrastructure.Managers.ProductManager;

/// <summary>
/// Менеджер для продуктов.
/// </summary>
public interface IProductManager
{
    /// <summary>
    /// Запрос получения всех продуктов.
    /// </summary>
    Task<List<ProductResponseDto>> GetAll();

    /// <summary>
    /// Запрос получения продуктов по идентификатору категории.
    /// </summary>
    /// <param name="categoryid">Идентификатор категории.</param>
    Task<List<ProductResponseDto>> GetByCategoryId(Guid categoryid);

    /// <summary>
    /// Запрос получения продукта по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор продукта.</param>
    Task<ProductResponseDto> GetById(Guid id);
}
