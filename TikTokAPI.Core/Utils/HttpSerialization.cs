using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace TikTokAPI.Core.Utils;

public static class HttpSerialization
{
    public static HttpContent ObjectToHttpContent<T>(T obj)
    {
        string jsonModel = JsonConvert.SerializeObject(obj);

        return new StringContent(jsonModel, Encoding.UTF8, MediaTypeNames.Application.Json);
    }

    public static async Task<T?> HttpResponseToObject<T>(HttpContent response)
    {
        var content = await response.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<T>(content);
    }
}
