using MediatR;
using Ardalis.Result;
using System.ComponentModel.DataAnnotations;

namespace TikTokAPI.Application.Video.Commands;

public class UploadVideoCommand : IRequest<Result<UploadVideoResponse>>
{
    [Required]
    public string Title { get; set; }

    [Required]
    public string VideoUrl { get; set; }
}
