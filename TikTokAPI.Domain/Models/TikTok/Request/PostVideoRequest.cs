using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using TikTokAPI.Domain.Models.TikTok.Mapping;

namespace TikTokAPI.Domain.Models.TikTok.Request;

public sealed class PostVideoRequest
{
    [JsonProperty(PropertyName = "post_info")]
    public required PostVideoInfoRequest Info { get; set; }

    [JsonProperty(PropertyName = "source_info")]
    public required SourceInfoRequest SourceInfo { get; set; }
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

    [MaxLength(150)]
    [JsonProperty(PropertyName = "title")]
    public required string Title { get; set; }


    ///<summary>
    /// If set to true, other TikTok users will not be allowed to make Duets using this post.
    /// TikTok server disables Duets for private accounts and those who set the Duet permission to "No one" in their privacy setting.
    ///</summary>
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