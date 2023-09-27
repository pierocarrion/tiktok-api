using MediatR;
using Microsoft.Extensions.Options;
using TikTokAPI.Core.AppSettings;
using TikTokAPI.Domain.Models.TikTok;
using TikTokAPI.Domain.Services;

namespace TikTokAPI.Infraestructure.Services
{
    internal sealed class TikTokClient : ITikTokClient
    {
        private readonly TikTokOptions _tikTokOptions;
        public TikTokClient(IOptions<TikTokOptions> tiktokOptions)
        {
            _tikTokOptions = tiktokOptions.Value;
        }
        public async Task<VideoUploadResponse> UploadVideo(VideoUploadRequest request)
        {
            if (request.IsInitPostNeeded)
            {
                VideoUploadResponse response = await InitUpload(request);
                if(response.Error.Code == "ok")
                {
                    // PUT Video
                    return await PutVideo(request);
                }
                return null;
            }

            return await DirectUploadVideo(request);
        }

        private async Task<VideoUploadResponse> InitUpload(VideoUploadRequest request)
        {
            return null;
        }

        private async Task<VideoUploadResponse> PutVideo(VideoUploadRequest request)
        {
            return null;
        }

        private async Task<VideoUploadResponse> DirectUploadVideo(VideoUploadRequest request)
        {
            return null;
        }
    }
}
