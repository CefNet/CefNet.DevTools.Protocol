//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Network
{
    /// <summary>
    /// [Experimental] Types of reasons why a cookie may not be sent with a request.
    /// </summary>
    public enum CookieBlockedReason
    {
        SecureOnly = 1,
        NotOnPath,
        DomainMismatch,
        SameSiteStrict,
        SameSiteLax,
        SameSiteUnspecifiedTreatedAsLax,
        SameSiteNoneInsecure,
        UserPreferences,
        UnknownError,
        SchemefulSameSiteStrict,
        SchemefulSameSiteLax,
        SchemefulSameSiteUnspecifiedTreatedAsLax,
        SamePartyFromCrossPartyContext,
    }
}
