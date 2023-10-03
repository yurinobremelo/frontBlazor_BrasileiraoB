using Blazor_BrasileiraoB;
using Blazor_BrasileiraoB.Pages.Service;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var baseURL = "https://api.api-futebol.com.br/v1/campeonatos/14/";

builder.Services.AddScoped(sp => new HttpClient {
    BaseAddress = new Uri(baseURL)
});

builder.Services.AddScoped<ITabelaService,TabelaService>();

await builder.Build().RunAsync();
