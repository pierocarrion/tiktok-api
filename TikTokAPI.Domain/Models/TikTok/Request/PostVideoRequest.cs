using Newtonsoft.Json;
using TikTokAPI.Domain.Models.TikTok.Mapping;

namespace TikTokAPI.Domain.Models.TikTok.Request;

public sealed class PostVideoRequest
{
    [JsonProperty(PropertyName = "post_info")]
    public PostVideoInfoRequest Info { get; set; }

    [JsonProperty(PropertyName = "source_info")]
    public SourceInfoRequest SourceInfo { get; set; }
}

public sealed class PostVideoInfoRequest
{
    [JsonIgnore]
    public required PrivacyLevelEnum PrivacyLevel { get; set; }

    [JsonProperty(PropertyName = "privacy_level")]
    public string RawPrivacyLevel
    {
        get
        {
            return EnumMapping.PrivacyLevelEnumString[PrivacyLevel];
        }
    }

    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    [JsonProperty(PropertyName = "disable_duet")]
    public bool DisableDuet { get; set; }

    [JsonProperty(PropertyName = "disable_stitch")]
    public bool DisableStitch {  get; set; }

    [JsonProperty(PropertyName = "disable_comment")]
    public bool DisableComment { get; set; }

    [JsonProperty(PropertyName = "video_cover_timestamp_ms")]
    public int DisableVideoCoverTimestampMs { get; set; }

    [JsonProperty(PropertyName = "brand_content_toggle")]
    public bool BrandContentToggle { get; set; }

    [JsonProperty(PropertyName = "brand_organic_toggle")]
    public bool BrandOrganicToggle { get; set; }
}