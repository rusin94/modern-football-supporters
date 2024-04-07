using MFS.Client.Extensions;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.AddRootComponents();
builder.AddClientServices();

builder.Services.AddScoped<DialogService>();
await builder.Build().RunAsync();
