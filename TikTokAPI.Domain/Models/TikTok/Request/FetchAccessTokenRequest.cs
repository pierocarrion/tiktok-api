namespace TikTokAPI.Domain.Models.TikTok.Request
{
    public class FetchAccessTokenRequest
    {
        public string ClientKey { get; set; }
        public string ClientSecret { get; set; }
        public string Code { get; set; }
        public string RedirectUri { get; set; }
        public string CodeVerifier { get; set; }
        public string GrantType { get; set; } = "authorization_code";
    }
}
