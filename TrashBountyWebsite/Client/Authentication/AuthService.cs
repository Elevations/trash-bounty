using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http;
using TrashBountyWebsite.Client.Authentication;
using Blazored.LocalStorage;
using System.Threading.Tasks;
using System.Net.Http.Json;
 // Figure out this package thing
using TrashBountyLib.Models.Results;
using TrashBountyWebsite.Client.Pages;
using TrashBountyLib.Models;
using System.Text;
using System.Text.Json;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TrashBountyWebsite.Client.Authentication
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;
        private readonly AuthenticationStateProvider _authStateProvider;
        private readonly ILocalStorageService _localStorage;

        public AuthService(HttpClient httpClient, AuthenticationStateProvider authStateProvider, ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _authStateProvider = authStateProvider;
            _localStorage = localStorage;
        }

        public async Task<RegisterResult> Register(NewUser user)
        {
            var result = await _httpClient.PostAsJsonAsync("https://localhost:44399/api/users", user);

            return result.Content.ReadFromJsonAsync<RegisterResult>().Result;
        }

        public async Task<LoginResult> Login(ReturningUser user)
        {
            /*
            //var loginAsJson = JsonSerializer.Serialize(user);
            //var response = await _httpClient.PostAsync($"https://localhost:44399/api/users/{user.Id}", new StringContent(loginAsJson, Encoding.UTF8, "application/json"));
            */ // bruh i had already commented them out [insert nooo, you can't just mlti-line comments which are already single lined, haha- comment go brrr]

            // Find the id of the user based on email
            List<User> users = new List<User>();
            /*
            users = await _httpClient.GetFromJsonAsync<List<User>>("https://localhost:44399/api/users"); //ah yes, errors in comments, my favorite >:L(
            User realUser = users.Find(u => u.Email == user.Email);
            */

            var task = await _httpClient.GetAsync("https://localhost:44399/api/users");
            var jsonString = await task.Content.ReadAsStringAsync();
            users = JsonConvert.DeserializeObject<List<User>>(jsonString);
            User realUser = users.Find(u => u.Email == user.Email);

            if (realUser == null)
                return new LoginResult { Successful = false, Error = "No user exists with that email" };

            var response = await _httpClient.PostAsJsonAsync($"https://localhost:44399/api/users/{realUser.Id}", user);
            var loginResult = System.Text.Json.JsonSerializer.Deserialize<LoginResult>(await response.Content.ReadAsStringAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            await _localStorage.SetItemAsync("authToken", loginResult.Token);
            ((AuthStateProvider) _authStateProvider).MarkUserAsAuthenticated(user.Email);
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer", loginResult.Token);

            return loginResult;
        }

        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("authToken");
            ((AuthStateProvider) _authStateProvider).MarkUserAsLoggedOut();
            _httpClient.DefaultRequestHeaders.Authorization = null;
        }
    }
}
