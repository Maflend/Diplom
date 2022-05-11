using Diplom.API.Dto.Responses;
using MediatR;

namespace Diplom.Application.Abstracts.Mediator.Authentication.Commands
{
    /// <summary>
    /// Команда авторизации.
    /// </summary>
    public class LoginCommand : IRequest<LoginResponseDto>
    {
        /// <summary>
        /// Имя пользователя.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Пароль.
        /// </summary>
        public string Password { get; set; }
    }
}
