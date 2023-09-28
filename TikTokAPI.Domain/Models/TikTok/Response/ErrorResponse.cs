using Newtonsoft.Json;
using TikTokAPI.Domain.Models.TikTok.Mapping;

namespace TikTokAPI.Domain.Models.TikTok.Response;

public sealed class ErrorResponse
{
    [JsonProperty(PropertyName = "code")]
    public string RawCode { get; init; }

    [JsonProperty(PropertyName = "message")]
    public string Message { get; init; }

    [JsonProperty(PropertyName = "log_id")]
    public string LogId { get; init; }

    [JsonIgnore]
    public ErrorCodeEnum Code => MapStringToEnum();

    private ErrorCodeEnum MapStringToEnum()
    {
        if (EnumMapping.ErrorCodeEnumMap.ContainsKey(this.RawCode))
        {
            return EnumMapping.ErrorCodeEnumMap[this.RawCode];
        }
        return ErrorCodeEnum.NO_CODE;
    }
}
