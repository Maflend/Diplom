using Blazored.LocalStorage;
using Diplom.API.Dto;
using Diplom.API.Dto.Requests;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Json;

namespace Diplom.Client.Infrastructure.Managers.AuthenticationManager
{
    public class AuthenticationManager : IAuthenticationManager
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorage;
        private readonly AuthenticationStateProvider _authenticationStateProvider;

        public string ErrorMessage { get; set; } = string.Empty;
        public AuthenticationManager(HttpClient httpClient, ILocalStorageService localStorage, AuthenticationStateProvider authenticationStateProvider)
        {
            _httpClient = httpClient;
            _localStorage = localStorage;
            _authenticationStateProvider = authenticationStateProvider;
        }
        public async Task<bool> Login(LoginRequestDto request)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.AuthenticationEndpoints.Login, request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                ErrorMessage = (await response.Content.ReadFromJsonAsync<ServerErrorResponse>()).Message;
                return false;
            }
            var desegializingResponse = await response.Content.ReadAsStringAsync();
            await _localStorage.SetItemAsync("token", desegializingResponse);
            await _authenticationStateProvider.GetAuthenticationStateAsync();

            return true;
        }

        public async Task<bool> Register(RegisterRequestDto request)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.AuthenticationEndpoints.Register, request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                ErrorMessage = (await response.Content.ReadFromJsonAsync<ServerErrorResponse>()).Message;
                return false;
            }

            return true;
        }

        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("token");
            await _authenticationStateProvider.GetAuthenticationStateAsync();
        }
    }
}
