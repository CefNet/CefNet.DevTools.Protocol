//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Network
{
    /// <summary>
    /// [Experimental] Types of reasons why a cookie may not be stored from a response.
    /// </summary>
    public enum SetCookieBlockedReason
    {
        SecureOnly = 1,
        SameSiteStrict,
        SameSiteLax,
        SameSiteUnspecifiedTreatedAsLax,
        SameSiteNoneInsecure,
        UserPreferences,
        SyntaxError,
        SchemeNotSupported,
        OverwriteSecure,
        InvalidDomain,
        InvalidPrefix,
        UnknownError,
        SchemefulSameSiteStrict,
        SchemefulSameSiteLax,
        SchemefulSameSiteUnspecifiedTreatedAsLax,
        SamePartyFromCrossPartyContext,
        SamePartyConflictsWithOtherAttributes,
    }
}
