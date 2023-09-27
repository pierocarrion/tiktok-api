using MediatR;
using TikTokAPI.Domain.Entities.VideoAggregate.Events;

namespace TikTokAPI.Application.EventHandlers;

public class VideoEventHandler : INotificationHandler<VideoUploadedEvent>
{
    public VideoEventHandler() { }
    public Task Handle(VideoUploadedEvent notification, CancellationToken cancellationToken)
    {
        // TODO: Send Notification
        throw new NotImplementedException();
    }
}
