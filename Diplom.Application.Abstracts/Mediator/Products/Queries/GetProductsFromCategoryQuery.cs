using Diplom.API.Dto.Responses;
using MediatR;

namespace Diplom.Application.Abstracts.Mediator.Products.Queries;

/// <summary>
/// Запрос получения списка продуктов по идентификатору категории.
/// </summary>
public class GetProductsFromCategoryQuery : IRequest<List<ProductResponseDto>>
{
    /// <summary>
    /// Идентификатор категории.
    /// </summary>
    public Guid CategoryId { get; set; }
}
