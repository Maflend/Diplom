using AutoMapper;
using Diplom.API.Dto.Responses;
using Diplom.Domain.Entities;

namespace Diplom.Mapping.Profiles
{
    /// <summary>
    /// Профиль продукта.
    /// </summary>
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductResponseDto>();
            CreateMap<Product, ShortProductResponseDto>();
        }
    }
}
