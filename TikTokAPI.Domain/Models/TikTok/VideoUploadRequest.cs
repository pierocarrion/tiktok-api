using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text.Json.Serialization;
using JsonIgnoreAttribute = Newtonsoft.Json.JsonIgnoreAttribute;

namespace TikTokAPI.Domain.Models.TikTok;

public class VideoUploadRequest
{
    [DataType(DataType.Text)]
    [JsonProperty(PropertyName = "source")]
    public VideoUploadEnum Source 
    { 
        get
        {
            if (this.Video != null)
            {
                return VideoUploadEnum.FILE_UPLOAD;
            }
            return VideoUploadEnum.PULL_FROM_URL;
        }
    }

    [DataType(DataType.Text)]
    [JsonProperty(PropertyName = "video_url")]
    public string VideoUrl { get; set; } = string.Empty;

    [JsonProperty(PropertyName = "video_size")]
    public int VideoSize { get; set; }

    [JsonProperty(PropertyName = "chunk_size")]
    public int ChunkSize { get; set; }

    [JsonProperty(PropertyName = "total_chunk_count")]
    public int TotalChunkCount { get; set; }

    [JsonIgnore]
    public byte[]? Video { get; set; }
    [JsonIgnore]
    public bool IsInitPostNeeded => Source == VideoUploadEnum.FILE_UPLOAD;



    public override string ToString()
    {
        return $"Source: {Source}, VideoUrl: {VideoUrl}, VideoSize: {VideoSize}, ChunkSize: {ChunkSize}, TotalChunkCount: {TotalChunkCount}";
    }
}
