using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WebAPP.Services;
using Domain;
using Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using WebAPP;
using Microsoft.EntityFrameworkCore;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped<userContext>();
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://localhost:7105/") 
});

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<App>("#app");


await builder.Build().RunAsync();
