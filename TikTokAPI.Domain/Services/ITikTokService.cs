using TikTokAPI.Domain.Models.TikTok;

namespace TikTokAPI.Domain.Services;

public interface ITikTokService
{
    public Task<VideoUploadResponse> UploadVideo(VideoUploadRequest request);
}
