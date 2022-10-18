using Ardalis.Specification;
using Diplom.Domain.Entities;

namespace Diplom.Domain.Specifications.ProductSpecifications;

/// <summary>
/// Спецификация продуктов.
/// </summary>
public class GetProductsSpec : Specification<Product>
{
    /// <summary>
    /// Получить продукты по идентификатору категории.
    /// </summary>
    /// <param name="categoryId">Идентификатор категории.</param>
    public GetProductsSpec(Guid categoryId)
    {
        Query.Where(p => p.CategoryId == categoryId);
    }
}
