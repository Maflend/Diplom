using AutoMapper;
using Diplom.API.Dto.Responses;
using Diplom.Domain.Entities;

namespace Diplom.Mapping.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrderResponseDto>();
        }
    }
}
