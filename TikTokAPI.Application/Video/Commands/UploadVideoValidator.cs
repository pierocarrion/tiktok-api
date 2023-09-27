using FluentValidation;

namespace TikTokAPI.Application.Video.Commands;

public class UploadVideoValidator : AbstractValidator<UploadVideoCommand>
{
    public UploadVideoValidator()
    {
        RuleFor(command => command.MaxLength)
            .NotEmpty();

        RuleFor(command => command.MaxQuantity)
            .NotEmpty()
            .LessThanOrEqualTo(6);
    }
}
