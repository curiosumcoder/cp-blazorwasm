using ba2;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// https://images-api.nasa.gov/search?q=spacex rocket&description=parachute&media_type=image
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://images-api.nasa.gov") });

await builder.Build().RunAsync();
