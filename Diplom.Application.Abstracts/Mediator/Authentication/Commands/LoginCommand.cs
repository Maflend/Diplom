using Diplom.API.Dto;
using Diplom.API.Dto.Responses;
using MediatR;

namespace Diplom.Application.Abstracts.Mediator.Authentication.Commands
{
    public class LoginCommand : IRequest<LoginResponseDto>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
