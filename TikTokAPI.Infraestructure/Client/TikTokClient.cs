using Microsoft.Extensions.Options;
using TikTokAPI.Core.AppSettings;
using TikTokAPI.Core.Extensions;
using TikTokAPI.Core.Utils;
using TikTokAPI.Domain.Client;
using TikTokAPI.Domain.Models.TikTok.Request;
using TikTokAPI.Domain.Models.TikTok.Response;

namespace TikTokAPI.Infraestructure.Client;

public sealed class TikTokClient : ITikTokClient
{
    public const string ClientName = nameof(TikTokClient);

    private readonly TikTokOptions _tikTokOptions;
    private readonly HttpClient _httpClient;

    public TikTokClient(HttpClient httpClient, IOptions<TikTokOptions> options)
    {
        _tikTokOptions = options.Value;
        
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri(_tikTokOptions.Host!);
    }

    public async Task<PostVideoResponse> InitUpload(PostVideoRequest request)
    {
        HttpContent content = HttpSerialization.ObjectToHttpContent(request);

        HttpResponseMessage response = await _httpClient.PostAsync(_tikTokOptions.UploadVideo!.Init, content);
        response.EnsureSuccessStatusCode();

        return (await response.Content.ReadAsStringAsync()).FromJson<PostVideoResponse>();
    }
    public async Task<PostVideoResponse> PutVideo(PostVideoRequest request)
    {
        HttpContent content = HttpSerialization.ObjectToHttpContent(request);

        HttpResponseMessage response = await _httpClient.PutAsync(_tikTokOptions.UploadVideo!.Init, content);
        response.EnsureSuccessStatusCode();

        return (await response.Content.ReadAsStringAsync()).FromJson<PostVideoResponse>();
    }
}
