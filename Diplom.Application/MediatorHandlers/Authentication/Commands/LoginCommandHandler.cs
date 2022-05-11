using Diplom.API.Dto.Responses;
using Diplom.Application.Abstracts.IServices;
using Diplom.Application.Abstracts.Mediator.Authentication.Commands;
using Diplom.Application.Exeptions;
using Diplom.Domain.Repositories.Abstracts;
using Diplom.Infrastructure.Specifications.UserSpecifications;
using MediatR;

namespace Diplom.Application.MediatorHandlers.Authentication.Commands
{
    /// <summary>
    /// Обработчик команды авторизации.
    /// </summary>
    public class LoginCommandHandler : IRequestHandler<LoginCommand, LoginResponseDto>
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IUserService _userService;
        private readonly IUserRepository _userRepository;

        public LoginCommandHandler(
            IUserRepository userRepository,
            IAuthenticationService authenticationService,
            IUserService userService
            )
        {
            _authenticationService = authenticationService;
            _userService = userService;
            _userRepository = userRepository;
        }

        /// <summary>
        /// Хэндлер.
        /// </summary>
        /// <param name="request"><see cref="LoginCommand"/></param>
        /// <param name="cancellationToken"></param>
        /// <returns><see cref="Task{TResult}">Task&lt;LoginResponseDto&gt;</see></returns>
        /// <exception cref="ServiceException"></exception>
        public async Task<LoginResponseDto> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetBySpecAsync(new GetUserSpec(request.UserName), cancellationToken);

            if (user == null)
            {
                throw new ServiceException("Пользователь не найден", ServiceExceptionType.NotFound);
            }

            if (!_userService.VerifyPasswordHash(request.Password, user.PasswordHash, user.PasswordSalt))
            {
                throw new ServiceException("Неверный пароль", ServiceExceptionType.BadRequest);
            }
            string token = _authenticationService.CreateToken(user);

            return new LoginResponseDto { Token = token };
        }
    }
}
