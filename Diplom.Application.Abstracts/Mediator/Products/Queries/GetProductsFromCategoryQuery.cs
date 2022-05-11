using Diplom.API.Dto.Responses;
using MediatR;

namespace Diplom.Application.Abstracts.Mediator.Products.Queries
{
    public class GetProductsFromCategoryQuery : IRequest<List<ProductResponseDto>>
    {
        public Guid CategoryId { get; set; }
    }
}
