using Microsoft.Extensions.DependencyInjection;

namespace MFS.Application.Extensions;

public static class ServiceExtension
{
    public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
    {
        return services;
    }
}