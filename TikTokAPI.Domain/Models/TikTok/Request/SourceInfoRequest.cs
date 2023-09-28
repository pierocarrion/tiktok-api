using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using TikTokAPI.Domain.Models.TikTok.Mapping;

namespace TikTokAPI.Domain.Models.TikTok.Request;

public class SourceInfoRequest
{
    [DataType(DataType.Text)]
    [JsonProperty(PropertyName = "source")]
    public string RawSource
    {
        get
        {
            return EnumMapping.SourceInfoEnumString[Source];
        }
    }

    [DataType(DataType.Text)]
    [JsonProperty(PropertyName = "video_url")]
    public string? VideoUrl { get; set; }

    [JsonProperty(PropertyName = "video_size")]
    public int? VideoSize { get; set; }

    [JsonProperty(PropertyName = "chunk_size")]
    public int? ChunkSize { get; set; }

    [JsonProperty(PropertyName = "total_chunk_count")]
    public int? TotalChunkCount { get; set; }

    [JsonIgnore]
    public byte[]? Video { get; set; }

    [JsonIgnore]
    public required SourceInfoEnum Source { get; set; }

    public override string ToString()
    {
        return $"Source: {Source}, VideoUrl: {VideoUrl}, VideoSize: {VideoSize}, ChunkSize: {ChunkSize}, TotalChunkCount: {TotalChunkCount}";
    }
}
