using AutoMapper;
using Diplom.API.Dto.Requests;
using Diplom.API.Dto.Responses;
using Diplom.Application.Abstracts.Mediator.Authentication.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Diplom.Server.Controllers
{
    /// <summary>
    /// Контроллер для аутентификации пользователя.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public AuthenticationController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        /// <summary>
        /// Зарегистрировать пользователя.
        /// </summary>
        /// <param name="request"><see cref="RegisterRequestDto"/>.</param>
        /// <returns><see cref="RegisterResponseDto"/></returns>
        [HttpPost("register")]
        public async Task<ActionResult<RegisterResponseDto>> RegisterAsync(RegisterRequestDto request)
        {
            RegisterCommand registerCommand = _mapper.Map<RegisterCommand>(request);
            var response = await _mediator.Send(registerCommand);

            return Ok(response);
        }

        /// <summary>
        /// Авторизировать пользователя.
        /// </summary>
        /// <param name="request"><see cref="LoginRequestDto"/></param>
        /// <returns>Токен.</returns>
        [HttpPost("login")]
        public async Task<ActionResult<string>> LoginAsync(LoginRequestDto request)
        {
            LoginCommand loginCommand = _mapper.Map<LoginCommand>(request);
            var response = await _mediator.Send(loginCommand);

            return Ok(response);
        }
    }
}
