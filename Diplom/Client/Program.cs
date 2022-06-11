using Blazored.LocalStorage;
using Blazored.Modal;
using Blazored.Toast;
using Diplom.Client;
using Diplom.Client.Infrastructure;
using Diplom.Client.Infrastructure.Authentication;
using Diplom.Client.Infrastructure.Services.Http;
using Diplom.Mapping;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Radzen;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddAuthorizationCore();
builder.Services.AddClientInfrastructure();
builder.Services.AddBlazoredToast();
builder.Services.AddBlazoredModal();
builder.Services.AddAutoMapper(typeof(AutoMapperAssembly));

builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<TooltipService>();
builder.Services.AddScoped<ContextMenuService>();

builder.Services.AddScoped<AuthenticationHeaderHandle>();
builder.Services.AddScoped<HttpPipeline>();

builder.Services.AddHttpClient(
    "ApiClient",
    client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
    )
    .AddHttpMessageHandler<AuthenticationHeaderHandle>()
    .AddHttpMessageHandler<HttpPipeline>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
