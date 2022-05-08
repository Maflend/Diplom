using AutoMapper;
using Diplom.API.Dto.Requests;
using Diplom.Application.Abstracts.Mediator.Authentication.Commands;

namespace Diplom.Mapping.Profiles.Mediator
{
    public class AuthenticationProfile : Profile
    {
        public AuthenticationProfile()
        {
            CreateMap<LoginRequestDto, LoginCommand>();
            CreateMap<RegisterRequestDto, RegisterCommand>();
        }
    }
}
