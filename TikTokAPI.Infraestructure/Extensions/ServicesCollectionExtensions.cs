using Microsoft.Extensions.DependencyInjection;

namespace TikTokAPI.Infraestructure.Extensions;

public static class ServicesCollectionExtensions
{
    public static IServiceCollection AddInfraestructure(this IServiceCollection services)
    {
        services.AddHttpClients();

        return services;
    }
}
