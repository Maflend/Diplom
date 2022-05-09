using AutoMapper;
using Diplom.API.Dto.Responses;
using Diplom.Application.Abstracts.Mediator.Products.Queries;
using Diplom.Application.Exeptions;
using Diplom.Domain.Repositories.Abstracts;
using MediatR;

namespace Diplom.Application.MediatorHandlers.Products.Queries
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, ProductResponseDto>
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public GetProductQueryHandler(IMapper mapper, IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async Task<ProductResponseDto> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.Id, cancellationToken);

            if (product == null)
            {
                throw new ServiceException("Продукт не найден.", ServiceExceptionType.NotFound);
            }
            var result = _mapper.Map<ProductResponseDto>(product);

            return result;
        }
    }
}
