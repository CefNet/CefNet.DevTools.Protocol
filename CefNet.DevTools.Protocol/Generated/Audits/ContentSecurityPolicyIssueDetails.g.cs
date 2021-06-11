//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Audits
{
    public sealed class ContentSecurityPolicyIssueDetails
    {
        /// <summary>The url not included in allowed sources.</summary>
        public string? BlockedURL { get; set; }

        /// <summary>
        /// Specific directive that is violated, causing the CSP issue.
        /// </summary>
        public string ViolatedDirective { get; set; }

        public bool IsReportOnly { get; set; }

        public CefNet.DevTools.Protocol.Audits.ContentSecurityPolicyViolationType ContentSecurityPolicyViolationType { get; set; }

        public CefNet.DevTools.Protocol.Audits.AffectedFrame? FrameAncestor { get; set; }

        public CefNet.DevTools.Protocol.Audits.SourceCodeLocation? SourceCodeLocation { get; set; }

        public CefNet.DevTools.Protocol.DOM.BackendNodeId? ViolatingNodeId { get; set; }
    }
}
