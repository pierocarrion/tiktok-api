using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using JsonNet.ContractResolvers;

namespace TikTokAPI.Core.Extensions;

public static class JsonExtensions
{
    private static readonly CamelCaseNamingStrategy CamelCaseNaming = new();
    private static readonly StringEnumConverter StringEnumConverter = new(CamelCaseNaming);
    private static readonly PrivateSetterContractResolver ContractResolver = new() { NamingStrategy = CamelCaseNaming };
    private static readonly JsonSerializerSettings DefaultJsonSettings = new JsonSerializerSettings().Configure();

    public static T FromJson<T>(this string value) =>
        value != null ? JsonConvert.DeserializeObject<T>(value, DefaultJsonSettings) : default;

    public static string ToJson<T>(this T value) =>
        value != null ? JsonConvert.SerializeObject(value, typeof(T), DefaultJsonSettings) : default;

    public static JsonSerializerSettings Configure(this JsonSerializerSettings jsonSettings)
    {
        // Ignore circular references
        jsonSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
        // Disable preserving references
        jsonSettings.PreserveReferencesHandling = PreserveReferencesHandling.None;
        // Ignore null values during serialization
        jsonSettings.NullValueHandling = NullValueHandling.Ignore;
        // Disable formatting of the JSON output
        jsonSettings.Formatting = Formatting.None;
        // Set the contract resolver for custom serialization behavior
        jsonSettings.ContractResolver = ContractResolver;
        // Add a converter for string enum values
        jsonSettings.Converters.Add(StringEnumConverter);
        return jsonSettings;
    }
}
