using Microblog.Api.Interfaces;
using Microblog.Api.Services;

namespace Microblog.Api.DependencyInjections;

public static class DependencyInjection
{
    public static IServiceCollection AddServices(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddPersistence(configuration);

        services.AddScoped<IPostService, PostService>();

        return services;
    }
}