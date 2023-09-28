using Microsoft.Extensions.Options;
using TikTokAPI.Core.AppSettings;
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

    public async Task<VideoUploadResponse> InitUpload(SourceVideoRequest request)
    {
        HttpContent content = HttpSerialization.ObjectToHttpContent(request);

        HttpResponseMessage response = await _httpClient.PostAsync(_tikTokOptions.UploadVideo!.Init, content);
        response.EnsureSuccessStatusCode();
        
        return await HttpSerialization.HttpResponseToObject<VideoUploadResponse>(response.Content);
    }
    public async Task<VideoUploadResponse> PutVideo(SourceVideoRequest request)
    {
        HttpContent content = HttpSerialization.ObjectToHttpContent(request);

        HttpResponseMessage response = await _httpClient.PutAsync(_tikTokOptions.UploadVideo!.Init, content);
        response.EnsureSuccessStatusCode();

        return await HttpSerialization.HttpResponseToObject<VideoUploadResponse>(response.Content);
    }
}
