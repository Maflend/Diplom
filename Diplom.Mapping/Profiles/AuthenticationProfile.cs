using AutoMapper;
using Diplom.API.Dto.Requests;
using Diplom.Application.Abstracts.Mediator.Authentication.Commands;

namespace Diplom.Mapping.Profiles;

/// <summary>
/// Профиль аутентификации Mediator.
/// </summary>
public class AuthenticationProfile : Profile
{
    public AuthenticationProfile()
    {
        CreateMap<LoginRequestDto, LoginCommand>();
        CreateMap<RegisterRequestDto, RegisterCommand>();
    }
}
