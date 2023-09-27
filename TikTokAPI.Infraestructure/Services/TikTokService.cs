using MediatR;
using Microsoft.Extensions.Options;
using TikTokAPI.Core.AppSettings;
using TikTokAPI.Domain.Client;
using TikTokAPI.Domain.Models.TikTok;
using TikTokAPI.Domain.Services;
using TikTokAPI.Infraestructure.Extensions;

namespace TikTokAPI.Infraestructure.Services
{
    internal sealed class TikTokService : ITikTokService
    {
        private readonly ITikTokClient _tikTokClient;
        public TikTokService(ITikTokClient tikTokClient)
        {
            _tikTokClient = tikTokClient;
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
            HttpClient a = new HttpClient();

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
