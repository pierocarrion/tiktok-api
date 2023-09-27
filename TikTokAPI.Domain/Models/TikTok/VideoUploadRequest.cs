using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TikTokAPI.Domain.Models.TikTok;

public class VideoUploadRequest
{
    [DataType(DataType.Text)]
    [JsonProperty(PropertyName = "source")]
    public VideoUploadEnum Source { get; set; } = VideoUploadEnum.PULL_FROM_URL;

    [DataType(DataType.Text)]
    [JsonProperty(PropertyName = "video_url")]
    public string VideoUrl { get; set; } = string.Empty;

    [JsonProperty(PropertyName = "video_size")]
    public int VideoSize { get; set; }

    [JsonProperty(PropertyName = "chunk_size")]
    public int ChunkSize { get; set; }

    [JsonProperty(PropertyName = "total_chunk_count")]
    public int TotalChunkCount { get; set; }

    public override string ToString()
    {
        return $"Source: {Source}, VideoUrl: {VideoUrl}, VideoSize: {VideoSize}, ChunkSize: {ChunkSize}, TotalChunkCount: {TotalChunkCount}";
    }
}
