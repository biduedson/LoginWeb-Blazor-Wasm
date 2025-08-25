using LoginWeb;
using LoginWeb.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using System.Net.Http; // Add this using directive to ensure HttpClient and related types are recognized.  

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddScoped(sp => new HttpClient()
{
    BaseAddress = new Uri("https://localhost:5100")
});

builder.Services.AddScoped<FingerprintService>();

await builder.Build().RunAsync();
