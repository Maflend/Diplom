using AutoMapper;
using Diplom.API.Dto.Responses;
using Diplom.Domain.Entities;

namespace Diplom.Mapping.Profiles;

/// <summary>
/// Профиль заказа.
/// </summary>
public class OrderProfile : Profile
{
    public OrderProfile()
    {
        CreateMap<Order, OrderResponseDto>();
        CreateMap<Order, OrderWithSalesDto>().ForMember(dest => dest.SalesCount, opt => opt.MapFrom(src => src.Sales.Select(s => s.Quantity).Sum()));
    }
}
