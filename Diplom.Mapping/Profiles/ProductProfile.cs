using AutoMapper;
using Diplom.API.Dto.Responses;
using Diplom.Domain.Entities;

namespace Diplom.Mapping.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductResponseDto>();
        }
    }
}
