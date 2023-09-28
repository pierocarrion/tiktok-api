using TikTokAPI.Domain.Models.TikTok.Request;
using TikTokAPI.Domain.Models.TikTok.Response;

namespace TikTokAPI.Domain.Services;

public interface ITikTokService
{
    public Task<VideoUploadResponse> UploadVideo(SourceVideoRequest request);
}
