//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Audits
{
    /// <summary>
    /// This struct holds a list of optional fields with additional information
    /// specific to the kind of issue. When adding a new issue code, please also
    /// add a new optional field to this type.
    /// </summary>
    public sealed class InspectorIssueDetails
    {
        public CefNet.DevTools.Protocol.Audits.SameSiteCookieIssueDetails? SameSiteCookieIssueDetails { get; set; }

        public CefNet.DevTools.Protocol.Audits.MixedContentIssueDetails? MixedContentIssueDetails { get; set; }

        public CefNet.DevTools.Protocol.Audits.BlockedByResponseIssueDetails? BlockedByResponseIssueDetails { get; set; }

        public CefNet.DevTools.Protocol.Audits.HeavyAdIssueDetails? HeavyAdIssueDetails { get; set; }

        public CefNet.DevTools.Protocol.Audits.ContentSecurityPolicyIssueDetails? ContentSecurityPolicyIssueDetails { get; set; }

        public CefNet.DevTools.Protocol.Audits.SharedArrayBufferIssueDetails? SharedArrayBufferIssueDetails { get; set; }

        public CefNet.DevTools.Protocol.Audits.TrustedWebActivityIssueDetails? TwaQualityEnforcementDetails { get; set; }

        public CefNet.DevTools.Protocol.Audits.LowTextContrastIssueDetails? LowTextContrastIssueDetails { get; set; }

        public CefNet.DevTools.Protocol.Audits.CorsIssueDetails? CorsIssueDetails { get; set; }

        public CefNet.DevTools.Protocol.Audits.AttributionReportingIssueDetails? AttributionReportingIssueDetails { get; set; }

        public CefNet.DevTools.Protocol.Audits.QuirksModeIssueDetails? QuirksModeIssueDetails { get; set; }

        public CefNet.DevTools.Protocol.Audits.NavigatorUserAgentIssueDetails? NavigatorUserAgentIssueDetails { get; set; }

        public CefNet.DevTools.Protocol.Audits.WasmCrossOriginModuleSharingIssueDetails? WasmCrossOriginModuleSharingIssue { get; set; }
    }
}
