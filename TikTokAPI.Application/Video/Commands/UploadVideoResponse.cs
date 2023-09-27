using TikTokAPI.Core.Shared_Kernel;

namespace TikTokAPI.Application.Video.Commands;

public class UploadVideoResponse : IResponse
{
    public Guid Id { get; }
    public UploadVideoResponse(Guid id) => Id = id;
}
