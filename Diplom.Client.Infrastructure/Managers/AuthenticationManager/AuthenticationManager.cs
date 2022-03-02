using Blazored.LocalStorage;
using Diplom.Application.Models;
using Diplom.Application.Models.Requests;
using Diplom.Application.Models.Responses;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

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
        public async Task<bool> Login(LoginRequest request)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.AuthenticationEndpoints.Login, request);
            var desegializingResponse = await response.Content.ReadFromJsonAsync<Response<string>>();
            if (!desegializingResponse.Success)
            {
                ErrorMessage = desegializingResponse.Message;
                return false;
            }
            await _localStorage.SetItemAsync("token", desegializingResponse.Data);

            await _authenticationStateProvider.GetAuthenticationStateAsync();
            return true;

        }

        public async Task<bool> Register(RegisterRequest request)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.AuthenticationEndpoints.Register, request);
            var desegializingResponse = await response.Content.ReadFromJsonAsync<Response<RegisterResponse>>();
           
            if (!desegializingResponse.Success)
            {
                ErrorMessage = desegializingResponse.Message;
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
