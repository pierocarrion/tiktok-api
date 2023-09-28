using Newtonsoft.Json;
using System;
using TikTokAPI.Domain.Models.TikTok.Mapping;

namespace TikTokAPI.Domain.Models.TikTok.Response;

public sealed class CreatorInformationResponse
{
    [JsonProperty(PropertyName = "data")]
    public CreatorInformationDataResponse Data { get; set; }

    [JsonProperty(PropertyName = "error")]
    public ErrorResponse Error { get; set; }
}

public sealed class CreatorInformationDataResponse
{
    [JsonProperty(PropertyName = "creator_avatar_url")]
    public string CreatorAvatarUrl { get; init; }

    [JsonProperty(PropertyName = "creator_username")]
    public string CreatorUsername { get; init; }

    [JsonProperty(PropertyName = "creator_nickname")]
    public string CreatorNickname { get; init; }

    [JsonProperty(PropertyName = "comment_disabled")]
    public bool CommentDisabled { get; init; }

    [JsonProperty(PropertyName = "duet_disabled")]
    public bool DuetDisabled { get; init; }

    [JsonProperty(PropertyName = "stitch_disabled")]
    public bool StitchDisabled { get; init; }

    [JsonProperty(PropertyName = "max_video_post_duration_sec")]
    public int MaxVideoPostDurationSec { get; init; }

    [JsonProperty(PropertyName = "privacy_level_options")]
    public List<string> RawPrivacyLevelOptions { get; init; } = new List<string>();

    [JsonIgnore]
    public IEnumerable<PrivacyLevelEnum> PrivacyLevelOptions => MapStringToEnum();

    private IEnumerable<PrivacyLevelEnum> MapStringToEnum()
    {
        foreach (string value in this.RawPrivacyLevelOptions)
        {
            if (EnumMapping.PrivacyLevelEnumMap.ContainsKey(value))
            {
                yield return EnumMapping.PrivacyLevelEnumMap[value];
            }
        }
    }
}