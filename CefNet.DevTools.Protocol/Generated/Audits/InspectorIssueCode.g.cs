//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Audits
{
    /// <summary>
    /// A unique identifier for the type of issue. Each type may use one of the
    /// optional fields in InspectorIssueDetails to convey more specific
    /// information about the kind of issue.
    /// </summary>
    public enum InspectorIssueCode
    {
        SameSiteCookieIssue = 1,
        MixedContentIssue,
        BlockedByResponseIssue,
        HeavyAdIssue,
        ContentSecurityPolicyIssue,
        SharedArrayBufferIssue,
        TrustedWebActivityIssue,
        LowTextContrastIssue,
        CorsIssue,
        AttributionReportingIssue,
        QuirksModeIssue,
        NavigatorUserAgentIssue,
        WasmCrossOriginModuleSharingIssue,
    }
}
