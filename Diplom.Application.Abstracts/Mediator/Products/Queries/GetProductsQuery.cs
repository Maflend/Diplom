using Diplom.API.Dto.Responses;
using MediatR;

namespace Diplom.Application.Abstracts.Mediator.Products.Queries;

/// <summary>
/// Запрос получения списка продуктов.
/// </summary>
public class GetProductsQuery : IRequest<List<ProductResponseDto>>
{
}
