using TikTokAPI.Domain.Models.TikTok.Request;
using TikTokAPI.Domain.Models.TikTok.Response;

namespace TikTokAPI.Domain.Services;

public interface ITikTokService
{
    Task<CreatorInformationResponse> GetUserInfo();
    Task<PostVideoResponse> PostVideoWithUrl(PostVideoRequest request);
    Task<PostVideoResponse> PostFileVideo(PostVideoRequest request);
}
