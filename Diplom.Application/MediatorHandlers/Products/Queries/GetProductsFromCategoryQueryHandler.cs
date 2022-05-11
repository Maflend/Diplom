using AutoMapper;
using Diplom.API.Dto.Responses;
using Diplom.Application.Abstracts.Mediator.Products.Queries;
using Diplom.Domain.Repositories.Abstracts;
using Diplom.Infrastructure.Specifications.ProductSpecifications;
using MediatR;

namespace Diplom.Application.MediatorHandlers.Products.Queries
{
    public class GetProductsFromCategoryQueryHandler : IRequestHandler<GetProductsFromCategoryQuery, List<ProductResponseDto>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductsFromCategoryQueryHandler(
            IProductRepository productRepository,
            IMapper mapper
            )
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductResponseDto>> Handle(GetProductsFromCategoryQuery request, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetAllBySpecAsync(new GetProductsSpec(request.CategoryId), cancellationToken);
            var result = _mapper.Map<List<ProductResponseDto>>(products);

            return result;
        }
    }
}
