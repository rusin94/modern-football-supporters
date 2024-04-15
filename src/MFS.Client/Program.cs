using MFS.Client.Extensions;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.AddRootComponents();
builder.AddClientServices();

await builder.Build().RunAsync();
