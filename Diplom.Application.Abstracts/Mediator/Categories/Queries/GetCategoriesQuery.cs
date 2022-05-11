using Diplom.API.Dto.Responses;
using MediatR;

namespace Diplom.Application.Abstracts.Mediator.Categories.Queries
{
    public class GetCategoriesQuery : IRequest<List<CategoryResponseDto>>
    {
    }
}
