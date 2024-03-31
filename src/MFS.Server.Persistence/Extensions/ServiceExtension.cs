using MFS.Server.Infrastructure.Interfaces.Repositories;
using MFS.Server.Persistence.Contexts;
using MFS.Server.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MFS.Server.Persistence.Extensions;

public static class ServiceExtension
{
    public static IServiceCollection AddPersistenceLayer(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("MFSContext")));

        services.AddScoped<ICommunityRepository, CommunityRepository>();
        services.AddScoped<INewsItemRepository, NewsItemRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        return services;
    }
}