using AutoMapper;
using Diplom.API.Dto.Dtos;
using Diplom.API.Dto.Requests;
using Diplom.Domain.Entities;

namespace Diplom.Mapping.Profiles;

/// <summary>
/// Профиль продажи.
/// </summary>
public class SaleProfile : Profile
{
    public SaleProfile()
    {
        CreateMap<CreateSaleDto, Sale>();
        CreateMap<SaleRequestDto, CreateSaleDto>();
    }
}
