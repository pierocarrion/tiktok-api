using TikTokAPI.Domain.Models.TikTok;

namespace TikTokAPI.Domain.Services;

public interface ITikTokClient
{
    public Task<VideoUploadResponse> UploadVideo(VideoUploadRequest request);
}
