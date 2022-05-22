using Blazor.Analytics;
using BlazorOnGitHubPages;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;

WebAssemblyHostBuilder builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient {
  BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});
builder.Services.AddGoogleAnalytics("G-X5GJT7QY9W");

await builder.Build().RunAsync();