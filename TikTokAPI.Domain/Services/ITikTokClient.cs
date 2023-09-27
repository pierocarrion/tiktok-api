using TikTokAPI.Domain.Models.TikTok;

namespace TikTokAPI.Domain.Services;

public interface ITikTokClient
{
    public VideoUploadRequest UploadVideo (VideoUploadRequest request);
}
