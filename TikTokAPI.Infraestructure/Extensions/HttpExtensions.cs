using Microsoft.Extensions.DependencyInjection;
using Polly;
using Polly.Contrib.WaitAndRetry;
using TikTokAPI.Domain.Client;
using TikTokAPI.Infraestructure.Client;

namespace TikTokAPI.Infraestructure.Extensions;

public static class HttpExtensions
{
    private static IHttpClientBuilder AddHttpPolicy(this IHttpClientBuilder httpClient)
    {
        return httpClient.AddPolicyHandler(
            Policy<HttpResponseMessage>
            .Handle<HttpRequestException>()
            //.OrResult(result => )
            .WaitAndRetryAsync(Backoff.DecorrelatedJitterBackoffV2(TimeSpan.FromSeconds(1), 5))
        );
    }

    public static IHttpClientBuilder AddHttpClients(this IServiceCollection services)
    {
        // All Clients
        return services
            .AddHttpClient<ITikTokClient, TikTokClient>()
            .AddHttpPolicy();
    }
}
