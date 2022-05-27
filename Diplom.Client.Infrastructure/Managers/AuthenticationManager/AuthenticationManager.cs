using Diplom.API.Dto;
using Diplom.API.Dto.Requests;
using Diplom.API.Dto.Responses;
using Diplom.Client.Infrastructure.Services.Authentication;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Json;

namespace Diplom.Client.Infrastructure.Managers.AuthenticationManager
{
    /// <summary>
    /// Менеджер для контроллера аутентификации.
    /// </summary>
    public class AuthenticationManager : IAuthenticationManager
    {
        private readonly HttpClient _httpClient;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly ITokenService _authenticationService;

        public string ErrorMessage { get; set; } = string.Empty;

        public AuthenticationManager(
            HttpClient httpClient,
            AuthenticationStateProvider authenticationStateProvider,
            ITokenService authenticationService
            )
        {
            _httpClient = httpClient;
            _authenticationStateProvider = authenticationStateProvider;
            _authenticationService = authenticationService;
        }

        /// <summary>
        /// Запрос для аутентификации.
        /// </summary>
        /// <param name="request"><see cref="LoginRequestDto"/></param>
        public async Task<bool> Login(LoginRequestDto request)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.AuthenticationEndpoints.Login, request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                ErrorMessage = (await response.Content.ReadFromJsonAsync<ServerResponseError>())?.Message ?? string.Empty;
                return false;
            }
            var token = (await response.Content.ReadFromJsonAsync<LoginResponseDto>())?.Token ?? string.Empty;
            await _authenticationService.SetTokenAsync(token);
            await _authenticationStateProvider.GetAuthenticationStateAsync();

            return true;
        }

        /// <summary>
        /// Запрос для регистрации.
        /// </summary>
        /// <param name="request"><see cref="RegisterRequestDto"/></param>
        public async Task<bool> Register(RegisterRequestDto request)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.AuthenticationEndpoints.Register, request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                ErrorMessage = (await response.Content.ReadFromJsonAsync<ServerResponseError>())?.Message ?? string.Empty;
                return false;
            }

            return true;
        }

        /// <summary>
        /// Выйти из пользователя.
        /// </summary>
        public async Task Logout()
        {
            await _authenticationService.DeleteTokenAsync();
            await _authenticationStateProvider.GetAuthenticationStateAsync();
        }
    }
}
