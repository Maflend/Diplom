using Diplom.Application.Abstracts.IServices;
using Diplom.Application.Abstracts.Mediator.Authentication.Commands;
using Diplom.Application.Exeptions;
using Diplom.Domain.Entities;
using Diplom.Domain.Enums;
using Diplom.Domain.Repositories.Abstracts;
using MediatR;

namespace Diplom.Application.MediatorHandlers.Authentication.Commands;

/// <summary>
/// Обработчик команды регистрации.
/// </summary>
public class RegisterCommandHandler : IRequestHandler<RegisterCommand, Unit>
{
    private readonly IUserRepository _userRepository;
    private readonly IUserService _userService;

    public RegisterCommandHandler(
        IUserRepository userRepository,
        IUserService userService
        )
    {
        _userRepository = userRepository;
        _userService = userService;
    }

    /// <summary>
    /// Хэндлер.
    /// </summary>
    /// <param name="request"><see cref="RegisterCommand"/></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <exception cref="ServiceException"></exception>
    public async Task<Unit> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        if (!await _userRepository.AnyAsync(u => u.UserName == request.UserName, cancellationToken))
        {
            _userService.CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);
            User user = new User()
            {
                Role = RoleEnum.Client,
                Age = request.Age,
                UserName = request.UserName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt
            };
            await _userRepository.AddAndSaveAsync(user, cancellationToken);
        }
        else
        {
            throw new ServiceException("Логин занят", ServiceExceptionType.BadRequest);
        }

        return Unit.Value;
    }
}
