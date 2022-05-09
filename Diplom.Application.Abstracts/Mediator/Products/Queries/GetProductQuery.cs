using Diplom.API.Dto.Responses;
using MediatR;

namespace Diplom.Application.Abstracts.Mediator.Products.Queries
{
    public class GetProductQuery : IRequest<ProductResponseDto>
    {
        public Guid Id { get; set; }
    }
}
