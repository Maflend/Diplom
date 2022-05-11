using Blazored.LocalStorage;
using Diplom.Client.Infrastructure.Services.Authentication;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using System.Text.Json;

namespace Diplom.Client.Infrastructure.Authentication
{
    /// <summary>
    /// Кастомный <see cref="AuthenticationStateProvider"/>.
    /// </summary>
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly HttpClient _http;
        private readonly ITokenService _authenticationService;

        public CustomAuthenticationStateProvider(HttpClient http, ITokenService authenticationService)
        {
            _http = http;
            _authenticationService = authenticationService;
        }

        /// <summary>
        /// Получить состояние аутентификации.
        /// </summary>
        /// <returns><see cref="Task{TResult}">Task&lt;AuthenticationState&gt;</see></returns>
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var state = new AuthenticationState(new ClaimsPrincipal());
            var token = await _authenticationService.GetTokenAsync();

            if (!string.IsNullOrEmpty(token))
            {
                try
                {
                    var claims = ParseClaimsFromJwt(token);

                    var identity = new ClaimsIdentity(claims, "AuthenticationJWT");
                    state = new AuthenticationState(new ClaimsPrincipal(identity));
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error GetAuthenticationStateAsync: " + ex.Message);
                }

            }
            NotifyAuthenticationStateChanged(Task.FromResult(state));

            return state;
        }

        /// <summary>
        /// Парсер клэймов из Json Web Token.
        /// </summary>
        /// <param name="jwt">Json Web Token.</param>
        /// <returns><see cref="List{T}">List&lt;Claim&gt;</see></returns>
        public static IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
        {
            var payload = jwt.Split('.')[1];
            var jsonBytes = ParseBase64WithoutPadding(payload);
            var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);

            return keyValuePairs.Select(kvp => new Claim(kvp.Key, kvp.Value.ToString()));
        }

        /// <summary>
        /// Парсинг токена в байтах.
        /// </summary>
        /// <param name="base64"></param>
        /// <returns></returns>
        private static byte[] ParseBase64WithoutPadding(string base64)
        {
            switch (base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }

            return Convert.FromBase64String(base64);
        }
    }
}
