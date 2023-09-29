using TikTokAPI.Domain.Client;
using TikTokAPI.Domain.Models.TikTok;
using TikTokAPI.Domain.Models.TikTok.Request;
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

        public async Task<CreatorInformationResponse> GetUserInfo()
        {
            return null;
        }

        public async Task<PostVideoResponse> PostVideoWithUrl(PostVideoRequest request)
        {
            // TODO: Custom Exception
            if (request.SourceInfo.Source is not SourceInfoEnum.PULL_FROM_URL) throw new Exception("");

            // Auth // TODO : SEND to commnd handler
            CreatorInformationResponse auth = await GetUserInfo();
            // 


            PostVideoResponse response = await _tikTokClient.InitUpload(request);

            if (response.Error.Code == ErrorCodeEnum.OK)
            {
                // PUT Video
            }

            throw new Exception("");
        }

        public async Task<PostVideoResponse> PostFileVideo(PostVideoRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
