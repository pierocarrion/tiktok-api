using Microsoft.Extensions.DependencyInjection;
using TikTokAPI.Domain.Client;
using TikTokAPI.Domain.Persistence;
using TikTokAPI.Domain.Services;
using TikTokAPI.Infraestructure.Client;
using TikTokAPI.Infraestructure.Persistence;
using TikTokAPI.Infraestructure.Services;

namespace TikTokAPI.Infraestructure.Extensions;

public static class ServicesCollectionExtensions
{
    public static IServiceCollection AddInfraestructure(this IServiceCollection services)
    {
        services
            .AddSingleton<ITikTokService, TikTokService>()
            .AddScoped<IUnitOfWork, UnitOfWork>()
            .AddHttpClients();

        return services;
    }
}
