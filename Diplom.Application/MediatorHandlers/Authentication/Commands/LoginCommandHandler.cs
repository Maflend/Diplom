using Diplom.API.Dto;
using Diplom.API.Dto.Responses;
using Diplom.Application.Abstracts.IServices;
using Diplom.Application.Abstracts.Mediator.Authentication.Commands;
using MediatR;

namespace Diplom.Application.MediatorHandlers.Authentication.Commands
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, Response<LoginResponseDto>>
    {
        private readonly IAuthenticationService _authenticationService;

        public LoginCommandHandler(IAuthenticationService authService)
        {
            _authenticationService = authService;
        }
        public async Task<Response<LoginResponseDto>> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var token = await _authenticationService.LoginAsync(request);

            return new Response<LoginResponseDto> { Data = new LoginResponseDto { Token = token }, Success = true };
        }
    }
}
