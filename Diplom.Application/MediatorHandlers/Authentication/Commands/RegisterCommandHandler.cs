using Diplom.Application.Abstracts.IServices;
using Diplom.Application.Abstracts.Mediator.Authentication.Commands;
using MediatR;

namespace Diplom.Application.MediatorHandlers.Authentication.Commands
{
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, Unit>
    {
        private readonly IAuthenticationService _authenticationService;

        public RegisterCommandHandler(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }
        public async Task<Unit> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            await _authenticationService.RegisterAsync(request, cancellationToken);
            return Unit.Value;
        }
    }
}
