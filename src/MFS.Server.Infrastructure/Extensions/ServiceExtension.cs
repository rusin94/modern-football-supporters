using Microsoft.Extensions.DependencyInjection;

namespace MFS.Server.Infrastructure.Extensions;

public static class ServiceExtension
{
    public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services)
    {
        return services;
    }
}