using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Globalization;
using MFS.Client.Infrastructure.Extensions;
using MFS.Client.Infrastructure.Managers;
using Radzen;

namespace MFS.Client.Extensions;

public static class WebAssemblyHostBuilderExtensions
{

    public static WebAssemblyHostBuilder AddRootComponents(this WebAssemblyHostBuilder builder)
    {
        builder.RootComponents.Add<App>("#app");
        builder.Services.AddRadzenComponents();
        return builder;
    }

    public static WebAssemblyHostBuilder AddClientServices(this WebAssemblyHostBuilder builder)
    {
        builder.Services
            .AddManagers()
            .AddHttpClient(SettingsExtension.ClientName, client =>
            {
                client.DefaultRequestHeaders.AcceptLanguage.Clear();
                client.DefaultRequestHeaders.AcceptLanguage.ParseAdd(CultureInfo.DefaultThreadCurrentCulture
                    ?.TwoLetterISOLanguageName);
                client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
            });
            Console.WriteLine(builder.HostEnvironment.BaseAddress);
        return builder;
    }
    public static IServiceCollection AddManagers(this IServiceCollection services)
    {
        var managers = typeof(IManager);

        var types = managers
            .Assembly
            .GetExportedTypes()
            .Where(t => t.IsClass && !t.IsAbstract)
            .Select(t => new
            {
                Service = t.GetInterface($"I{t.Name}"),
                Implementation = t
            })
            .Where(t => t.Service != null);

        foreach (var type in types)
        {
            if (managers.IsAssignableFrom(type.Service))
            {
                services.AddTransient(type.Service, type.Implementation);
            }
        }

        return services;
    }
}