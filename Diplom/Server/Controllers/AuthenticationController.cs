using AutoMapper;
using Diplom.API.Dto.Requests;
using Diplom.API.Dto.Responses;
using Diplom.Application.Abstracts.Mediator.Authentication.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Diplom.Server.Controllers
{
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

        [HttpPost("register")]
        public async Task<ActionResult<RegisterResponseDto>> RegisterAsync(RegisterRequestDto request)
        {
            RegisterCommand registerCommand = _mapper.Map<RegisterCommand>(request);
            var response = await _mediator.Send(registerCommand);
            return Ok(response);
        }

        [HttpPost("login")]
        public async Task<ActionResult<string>> LoginAsync(LoginRequestDto request)
        {
            LoginCommand loginCommand = _mapper.Map<LoginCommand>(request);
            var response = await _mediator.Send(loginCommand);
            return Ok(response);
        }
    }

}
