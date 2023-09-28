namespace TikTokAPI.Domain.Models.TikTok.Mapping;

public static class EnumMapping
{
    public static readonly Dictionary<string, PrivacyLevelEnum> PrivacyLevelEnumMap = new Dictionary<string, PrivacyLevelEnum>
    {
        { "SELF_ONLY", PrivacyLevelEnum.SELF_ONLY },
        { "PUBLIC_TO_EVERYONE", PrivacyLevelEnum.PUBLIC_TO_EVERYONE },
        { "MUTUAL_FOLLOW_FRIENDS", PrivacyLevelEnum.MUTUAL_FOLLOW_FRIENDS },
        { "FOLLOWER_OF_CREATOR", PrivacyLevelEnum.FOLLOWER_OF_CREATOR },
    };
    
    public static readonly Dictionary<PrivacyLevelEnum, string> PrivacyLevelEnumString = PrivacyLevelEnumMap.ToDictionary(pair => pair.Value, pair => pair.Key);

    public static readonly Dictionary<string, ErrorCodeEnum> ErrorCodeEnumMap = new Dictionary<string, ErrorCodeEnum>
    {
        { "OK", ErrorCodeEnum.OK },
        { "", ErrorCodeEnum.EMPTY },
        { "spam_risk_too_many_posts", ErrorCodeEnum.SPAM_RISK_TOO_MANY_POSTS },
        { "spam_risk_user_banned_from_posting", ErrorCodeEnum.SPAM_RISK_USER_BANNED_FROM_POSTING },
        { "reached_active_user_cap", ErrorCodeEnum.REACHED_ACTIVE_USER_CAP },
        { "unaudited_client_can_only_post_to_private_accounts", ErrorCodeEnum.UNAUDITED_CLIENT_CAN_ONLY_POST_TO_PRIVATE_ACCOUNTS },
        { "access_token_invalid", ErrorCodeEnum.ACCESS_TOKEN_INVALID },
        { "scope_not_authorized", ErrorCodeEnum.SCOPE_NOT_AUTHORIZED },
        { "rate_limit_exceeded", ErrorCodeEnum.RATE_LIMIT_EXCEEDED },
    };

    public static readonly Dictionary<ErrorCodeEnum, string> ErrorCodeEnumString = ErrorCodeEnumMap.ToDictionary(pair => pair.Value, pair => pair.Key);

    public static readonly Dictionary<string, SourceInfoEnum> SourceInfoEnumMap = new Dictionary<string, SourceInfoEnum>
    {
        { "PULL_FROM_URL", SourceInfoEnum.PULL_FROM_URL },
        { "FILE_UPLOAD", SourceInfoEnum.FILE_UPLOAD },
    };

    public static readonly Dictionary<SourceInfoEnum, string> SourceInfoEnumString = SourceInfoEnumMap.ToDictionary(pair => pair.Value, pair => pair.Key);
}
