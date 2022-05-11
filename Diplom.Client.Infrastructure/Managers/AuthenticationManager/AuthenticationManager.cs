using Blazored.LocalStorage;
using Diplom.API.Dto;
using Diplom.API.Dto.Requests;
using Diplom.API.Dto.Responses;
using Diplom.Client.Infrastructure.Services.Authentication;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Json;

namespace Diplom.Client.Infrastructure.Managers.AuthenticationManager
{
    public class AuthenticationManager : IAuthenticationManager
    {
        private readonly HttpClient _httpClient;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly ITokenService _authenticationService;

        public string ErrorMessage { get; set; } = string.Empty;
        public AuthenticationManager(HttpClient httpClient, AuthenticationStateProvider authenticationStateProvider, ITokenService authenticationService)
        {
            _httpClient = httpClient;
            _authenticationStateProvider = authenticationStateProvider;
            _authenticationService = authenticationService;
        }
        public async Task<bool> Login(LoginRequestDto request)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.AuthenticationEndpoints.Login, request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                ErrorMessage = (await response.Content.ReadFromJsonAsync<ServerErrorResponse>())?.Message ?? string.Empty;
                return false;
            }
            var token = (await response.Content.ReadFromJsonAsync<LoginResponseDto>())?.Token ?? string.Empty;
            await _authenticationService.SetTokenAsync(token);
            await _authenticationStateProvider.GetAuthenticationStateAsync();

            return true;
        }

        public async Task<bool> Register(RegisterRequestDto request)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.AuthenticationEndpoints.Register, request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                ErrorMessage = (await response.Content.ReadFromJsonAsync<ServerErrorResponse>())?.Message ?? string.Empty;
                return false;
            }

            return true;
        }

        public async Task Logout()
        {
            await _authenticationService.DeleteTokenAsync();
            await _authenticationStateProvider.GetAuthenticationStateAsync();
        }
    }
}
