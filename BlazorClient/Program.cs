using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorClient;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

string apiUrl = "https://azfunc-fqcbdmf3h7edcxdm.westus3-01.azurewebsites.net/api/students";
builder.Services.AddScoped(sp => new HttpClient { 
    BaseAddress = new Uri(apiUrl) 
});

await builder.Build().RunAsync();
