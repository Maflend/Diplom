using AutoMapper;
using Diplom.API.Dto.Responses;
using Diplom.Application.Abstracts.Mediator.Product.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Application.MediatorHandlers.Product.Queries
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, ProductResponseDto>
    {
        private readonly IMapper _mapper;

        public GetProductQueryHandler(IMapper mapper)
        {
            _mapper = mapper;
        }
        public Task<ProductResponseDto> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
