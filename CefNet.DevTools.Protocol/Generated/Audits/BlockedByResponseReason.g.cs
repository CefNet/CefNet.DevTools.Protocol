//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Audits
{
    /// <summary>
    /// Enum indicating the reason a response has been blocked. These reasons are
    /// refinements of the net error BLOCKED_BY_RESPONSE.
    /// </summary>
    public enum BlockedByResponseReason
    {
        CoepFrameResourceNeedsCoepHeader = 1,
        CoopSandboxedIFrameCannotNavigateToCoopPage,
        CorpNotSameOrigin,
        CorpNotSameOriginAfterDefaultedToSameOriginByCoep,
        CorpNotSameSite,
    }
}
