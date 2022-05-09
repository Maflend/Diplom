using Diplom.API.Dto.Responses;
using MediatR;

namespace Diplom.Application.Abstracts.Mediator.Products.Queries
{
    public class GetProductsQuery : IRequest<List<ProductResponseDto>>
    {
    }
}
