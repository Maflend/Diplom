using AutoMapper;
using Diplom.API.Dto.Dtos;
using Diplom.API.Dto.Requests;

namespace Diplom.Mapping.ClientProfiles
{
    public class CartProfile : Profile
    {
        public CartProfile()
        {
            CreateMap<CartDto, SaleRequestDto>().ForMember(dest => dest.ProductId, opt => opt.MapFrom(c => c.Product.Id));
        }
    }
}
