using Diplom.API.Dto.Responses;
using MediatR;

namespace Diplom.Application.Abstracts.Mediator.Products.Queries
{
    /// <summary>
    /// Запрос получения продукта по идентификатору.
    /// </summary>
    public class GetProductQuery : IRequest<ProductResponseDto>
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public Guid Id { get; set; }
    }
}
