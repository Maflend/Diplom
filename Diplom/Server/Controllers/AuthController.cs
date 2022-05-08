﻿using AutoMapper;
using Diplom.API.Dto.Requests;
using Diplom.Application.Abstracts.Mediator.Authentication.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Diplom.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public AuthController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }
        [HttpPost("register")]
        public async Task<ActionResult> Register(RegisterRequestDto request)
        {
            RegisterCommand registerCommand = _mapper.Map<RegisterCommand>(request);
            var response = await _mediator.Send(registerCommand);

            if (!response.Success)
            {
                return BadRequest(response.Message);
            }

            return Ok(response.Data);
        }
        [HttpPost("login")]
        public async Task<ActionResult> Login(LoginRequestDto request)
        {
            LoginCommand loginCommand = _mapper.Map<LoginCommand>(request);
            var response = await _mediator.Send(loginCommand);

            if (!response.Success)
            {
                return BadRequest(response.Message);
            }
            return Ok(response.Data);
        }
    }

}
