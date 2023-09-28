using TikTokAPI.Domain.Client;
using TikTokAPI.Domain.Models.TikTok;
using TikTokAPI.Domain.Models.TikTok.Response;
using TikTokAPI.Domain.Services;

namespace TikTokAPI.Infraestructure.Services
{
    /// <summary>
    /// Class <c>TikTokService</c> contains implementation of TikTok SDK.
    /// </summary>
    /// <remarks>
    /// More information: https://developers.tiktok.com/doc/content-posting-api-get-started/
    /// </remarks>
    internal sealed class TikTokService : ITikTokService
    {
        private readonly ITikTokClient _tikTokClient;
        public TikTokService(ITikTokClient tikTokClient)
        {
            _tikTokClient = tikTokClient;
        }

        public async Task<VideoUploadResponse> UploadVideo(Domain.Models.TikTok.Request.SourceInfoRequest request)
        {
            if (request.Source == Domain.Models.TikTok.SourceInfoEnum.PULL_FROM_URL)
            {
                VideoUploadResponse response = await _tikTokClient.InitUpload(request);
                if(response.Error.Code == Domain.Models.TikTok.ErrorCodeEnum.OK)
                {
                    // PUT Video
                    return await PutVideo(request);
                }
                return null;
            }

            return await DirectUploadVideo(request);
        }

        private async Task<VideoUploadResponse> PutVideo(Domain.Models.TikTok.Request.SourceInfoRequest request)
        {
            return null;
        }

        private async Task<VideoUploadResponse> DirectUploadVideo(Domain.Models.TikTok.Request.SourceInfoRequest request)
        {
            return null;
        }
    }
}
