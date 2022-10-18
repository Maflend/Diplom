using Diplom.API.Dto.Responses;
using MediatR;

namespace Diplom.Application.Abstracts.Mediator.Categories.Queries;

/// <summary>
/// Запрос получения списка категорий.
/// </summary>
public class GetCategoriesQuery : IRequest<List<CategoryResponseDto>>
{
}
