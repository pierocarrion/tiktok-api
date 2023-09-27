using MediatR;
using Ardalis.Result;
using System.ComponentModel.DataAnnotations;

namespace TikTokAPI.Application.Video.Commands;

public class UploadVideoCommand : IRequest<Result<UploadVideoResponse>>
{
    public int MaxLength { get; set; }

    [Required]
    [Range(0,6)]
    public int MaxQuantity { get; set; }
}
