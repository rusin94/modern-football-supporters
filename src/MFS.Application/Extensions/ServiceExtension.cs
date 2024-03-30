using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MFS.Application.Extensions;

public static class ServiceExtension
{
    public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        return services;
    }
}