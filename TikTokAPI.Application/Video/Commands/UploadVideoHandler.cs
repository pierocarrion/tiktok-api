using Ardalis.Result;
using MediatR;
using TikTokAPI.Domain.Models.TikTok.Request;
using TikTokAPI.Domain.Services;

namespace TikTokAPI.Application.Video.Commands;

public class UploadVideoHandler : IRequestHandler<UploadVideoCommand, Result<UploadVideoResponse>>
{
    private readonly ITikTokService _tikTokService;
    public UploadVideoHandler(ITikTokService tiktokService)
    {
        _tikTokService = tiktokService;
    }

    public async Task<Result<UploadVideoResponse>> Handle(UploadVideoCommand request, CancellationToken cancellationToken)
    {
        var userInfo = await _tikTokService.GetUserInfo();
        
        if (userInfo is null) throw new Exception("User Info not found");

        var postVideoRequest = new PostVideoRequest()
        {
            Info = new PostVideoInfoRequest() 
            { 
                PrivacyLevel = userInfo.Data.PrivacyLevelOptions.First(),
                Title = "TODO",
            },
            SourceInfo = new SourceInfoRequest() 
            { 
                Source = Domain.Models.TikTok.SourceInfoEnum.PULL_FROM_URL,
                VideoUrl = ""
            }
        };

        var response = await _tikTokService.PostVideoWithUrl(postVideoRequest);
        
        return Result<UploadVideoResponse>.Success(
            new UploadVideoResponse(Guid.NewGuid()), "Sucessfully uploaded");
    }
}
