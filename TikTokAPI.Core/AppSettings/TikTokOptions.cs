using TikTokAPI.Core.Shared_Kernel;

namespace TikTokAPI.Core.AppSettings;

public sealed class TikTokOptions : IAppOptions
{
    static string IAppOptions.ConfigSectionPath => nameof(TikTokOptions);

    public TikTokUploadVideoOptions? UploadVideo { get; init; }
    public TikTokVideoStatusOptions? VideoStatus { get; init; }
    public string? Host { get; init; }
    public string? AccessToken { get; init; }
}

public sealed class TikTokUploadVideoOptions
{
    public string? Init { get; init; }
}

public sealed class TikTokVideoStatusOptions
{
    public string? Status { get; init; }
}