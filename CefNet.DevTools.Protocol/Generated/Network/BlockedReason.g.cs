//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Network
{
    /// <summary>The reason why request was blocked.</summary>
    public enum BlockedReason
    {
        Other = 1,
        Csp,
        MixedContent,
        Origin,
        Inspector,
        SubresourceFilter,
        ContentType,
        CoepFrameResourceNeedsCoepHeader,
        CoopSandboxedIframeCannotNavigateToCoopPage,
        CorpNotSameOrigin,
        CorpNotSameOriginAfterDefaultedToSameOriginByCoep,
        CorpNotSameSite,
    }
}
