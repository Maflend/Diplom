using AutoMapper;
using Diplom.API.Dto.Responses;
using Diplom.Domain.Entities;

namespace Diplom.Mapping.Profiles;

/// <summary>
/// Профиль категории.
/// </summary>
public class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        CreateMap<Category, CategoryResponseDto>();
    }
}
