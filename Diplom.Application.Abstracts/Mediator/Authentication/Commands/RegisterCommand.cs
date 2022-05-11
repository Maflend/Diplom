using Diplom.API.Dto;
using Diplom.API.Dto.Responses;
using MediatR;

namespace Diplom.Application.Abstracts.Mediator.Authentication.Commands
{
    /// <summary>
    /// Команда регистрации.
    /// </summary>
    public class RegisterCommand : IRequest
    {
        /// <summary>
        /// Имя пользователя.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Возраст.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Пароль.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Подтверждение пароля.
        /// </summary>
        public string ConfirmPassword { get; set; }
    }
}
