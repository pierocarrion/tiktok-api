using Newtonsoft.Json;
using System.Net.Mime;
using System.Text;

namespace TikTokAPI.Core.Utils;

public static class HttpSerialization
{
    public static HttpContent ObjectToHttpContent<T>(T obj)
    {
        string jsonModel = JsonConvert.SerializeObject(obj);

        return new StringContent(jsonModel, Encoding.UTF8, MediaTypeNames.Application.Json);
    }
}
