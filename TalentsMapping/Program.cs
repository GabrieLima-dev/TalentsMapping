using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using TalentsMapping;
using TalentsMapping.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<CursoService>();
builder.Services.AddScoped<PerguntaService>();
builder.Services.AddScoped<UsuarioService>();
builder.Services.AddScoped<LocalStorageService>();



builder.Services.AddMudServices();

await builder.Build().RunAsync();
