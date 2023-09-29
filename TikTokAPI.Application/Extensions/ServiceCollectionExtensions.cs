using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace TikTokAPI.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static readonly Assembly ThisAssembly = Assembly.GetExecutingAssembly();

    public static IServiceCollection AddCQRS(this IServiceCollection services)
    {
        return services
            .AddMediatR(config => config.RegisterServicesFromAssembly(ThisAssembly))
            .AddValidatorsFromAssembly(ThisAssembly);
    }
}
