using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace TikTokAPI.Domain.Models.TikTok;

public class VideoUploadResponse
{
    public required VideoUploadResponseData Data { get; set; }
    public required VideoUploadResponseError Error { get; set; }

    public override string ToString()
    {
        return $"Data: {Data}, Error: {Error}";
    }
}

public sealed class VideoUploadResponseData
{
    [MaxLength(64)]
    [DataType(DataType.Text)]
    [JsonProperty(PropertyName = "publish_id")]
    public required string PublishId { get; set; }

    [MaxLength(256)]
    [DataType(DataType.Text)]
    [JsonProperty(PropertyName = "upload_url")]
    public required string UploadUrl { get; set; }

    public override string ToString()
    {
        return $"PublishId: {PublishId}, UploadUrl: {UploadUrl}";
    }
}
public sealed class VideoUploadResponseError
{
    [DataType(DataType.Text)]
    [JsonProperty(PropertyName = "code")]
    public required string Code { get; set; }

    [DataType(DataType.Text)]
    [JsonProperty(PropertyName = "message")]
    public required string Message { get; set; }

    [DataType(DataType.Text)]
    [JsonProperty(PropertyName = "log_id")]
    public required string LogId { get; set; }

    public override string ToString()
    {
        return $"Code: {Code}, Message: {Message}, LogId: {LogId}";
    }
}
