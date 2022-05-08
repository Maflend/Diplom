using Diplom.API.Dto;
using Diplom.API.Dto.Responses;
using MediatR;

namespace Diplom.Application.Abstracts.Mediator.Authentication.Commands
{
    public class RegisterCommand : IRequest
    {
        public string UserName { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
