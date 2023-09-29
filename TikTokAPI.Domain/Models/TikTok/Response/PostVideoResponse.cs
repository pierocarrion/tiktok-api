using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace TikTokAPI.Domain.Models.TikTok.Response;

public sealed class PostVideoResponse
{
    public required PostVideoResponseData Data { get; init; }
    public required ErrorResponse Error { get; init; }

    public override string ToString()
    {
        return $"Data: {Data}, Error: {Error}";
    }
}

public sealed class PostVideoResponseData
{
    [MaxLength(64)]
    [DataType(DataType.Text)]
    [JsonProperty(PropertyName = "publish_id")]
    public required string PublishId { get; init; }

    [MaxLength(256)]
    [DataType(DataType.Text)]
    [JsonProperty(PropertyName = "upload_url")]
    public required string UploadUrl { get; init; }

    public override string ToString()
    {
        return $"PublishId: {PublishId}, UploadUrl: {UploadUrl}";
    }
}
