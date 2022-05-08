using Diplom.API.Dto;
using Diplom.API.Dto.Responses;
using Diplom.Application.Abstracts.IServices;
using Diplom.Application.Abstracts.Mediator.Authentication.Commands;
using MediatR;

namespace Diplom.Application.MediatorHandlers.Authentication.Commands
{
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, Response<RegisterResponseDto>>
    {
        private readonly IAuthenticationService _authenticationService;

        public RegisterCommandHandler(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }
        public async Task<Response<RegisterResponseDto>> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            await _authenticationService.RegisterAsync(request);

            return new Response<RegisterResponseDto> { Success = true };

        }
    }
}
