using AutoMapper;
using Diplom.API.Dto.Responses;
using Diplom.Application.Abstracts.Mediator.Products.Queries;
using Diplom.Domain.Repositories.Abstracts;
using MediatR;

namespace Diplom.Application.MediatorHandlers.Products.Queries
{
    /// <summary>
    /// Обработчик запроса получения списка продуктов.
    /// </summary>
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, List<ProductResponseDto>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductsQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Хэндлер.
        /// </summary>
        /// <param name="request"><see cref="GetProductsQuery"/></param>
        /// <param name="cancellationToken"></param>
        /// <returns><see cref="Task{List{T}}">Task&lt;List&lt;ProductResponseDto&gt;&gt;</see></returns>
        public async Task<List<ProductResponseDto>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetAllAsync(cancellationToken);
            var result = _mapper.Map<List<ProductResponseDto>>(products);

            return result;
        }
    }
}
