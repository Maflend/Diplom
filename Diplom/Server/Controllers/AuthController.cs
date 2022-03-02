
using Diplom.Domain.Entities;
using Diplom.Domain.Interfaces;
using Diplom.Application.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Security.Cryptography;
using Diplom.Application.Models.Requests;
using Diplom.Application.Models.Responses;

namespace Diplom.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpPost("register")]
        public async Task<ActionResult> Register(RegisterRequest request)
        {
            try
            {
                var serviceResponse = await _authService.Register(request);
                var regResponse = new RegisterResponse {UserName = serviceResponse.UserName };
                return Ok(new Response<RegisterResponse> { Data = regResponse, Success = true });
            }
            catch (Exception ex)
            {
                return BadRequest(new Response<RegisterResponse> { Message = ex.Message, Success = false });
            }
        }
        [HttpPost("login")]
        public async Task<ActionResult<Response<string>>> Login(LoginRequest request)
        {
            try
            {
                var serviceResponse =  await _authService.Login(request);
                return Ok(new Response<string> {Data = serviceResponse, Success = true});
            }
            catch(Exception ex)
            {
                return BadRequest(new Response<string> { Message = ex.Message, Success = false});
            }
           
        }
    }
   
}
