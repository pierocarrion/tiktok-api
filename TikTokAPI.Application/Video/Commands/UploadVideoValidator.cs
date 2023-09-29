using FluentValidation;

namespace TikTokAPI.Application.Video.Commands;

public class UploadVideoValidator : AbstractValidator<UploadVideoCommand>
{
    public UploadVideoValidator()
    {
        RuleFor(command => command.VideoUrl)
            .NotEmpty();

        RuleFor(command => command.Title)
            .NotEmpty();
    }
}
