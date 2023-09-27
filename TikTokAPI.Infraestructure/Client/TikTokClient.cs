using Microsoft.Extensions.Options;
using TikTokAPI.Core.AppSettings;
using TikTokAPI.Domain.Client;
namespace TikTokAPI.Infraestructure.Client;

public sealed class TikTokClient : ITikTokClient
{
    public const string ClientName = nameof(TikTokClient);
    private readonly HttpClient _httpClient;

    public TikTokClient(HttpClient httpClient, IOptions<TikTokOptions> options)
    {
        string? host = options.Value.Host;
        
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri(host!);
    }
}
