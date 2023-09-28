using TikTokAPI.Domain.Models.TikTok.Request;
using TikTokAPI.Domain.Models.TikTok.Response;

namespace TikTokAPI.Domain.Client;

public interface ITikTokClient
{
    Task<VideoUploadResponse> InitUpload(SourceVideoRequest request);
}
