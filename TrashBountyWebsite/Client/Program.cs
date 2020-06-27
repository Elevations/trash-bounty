using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using TrashBountyWebsite.Client.Authentication;
using Microsoft.AspNetCore.Components.Authorization;
using Blazored.LocalStorage;
using Blazor.FileReader;

namespace TrashBountyWebsite.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddScoped<AuthenticationStateProvider, AuthStateProvider>();
            builder.Services.AddScoped<IAuthService, AuthService>();
            builder.Services.AddAuthenticationCore();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddFileReaderService(options =>
            {
                options.UseWasmSharedBuffer = true;
            });
            
            await builder.Build().RunAsync();
        }
    }
}
