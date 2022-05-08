using Diplom.API.Dto.Responses;
using Diplom.Application.Abstracts.IServices;
using Diplom.Application.Abstracts.Mediator.Authentication.Commands;
using MediatR;

namespace Diplom.Application.MediatorHandlers.Authentication.Commands
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, LoginResponseDto>
    {
        private readonly IAuthenticationService _authenticationService;

        public LoginCommandHandler(IAuthenticationService authService)
        {
            _authenticationService = authService;
        }
        public async Task<LoginResponseDto> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var token = await _authenticationService.LoginAsync(request, cancellationToken);

            return new LoginResponseDto { Token = token };
        }
    }
}
