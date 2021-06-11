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
    /// Details for issues around "Attribution Reporting API" usage.
    /// Explainer: https://github.com/WICG/conversion-measurement-api
    /// </summary>
    public sealed class AttributionReportingIssueDetails
    {
        public CefNet.DevTools.Protocol.Audits.AttributionReportingIssueType ViolationType { get; set; }

        public CefNet.DevTools.Protocol.Audits.AffectedFrame? Frame { get; set; }

        public CefNet.DevTools.Protocol.Audits.AffectedRequest? Request { get; set; }

        public CefNet.DevTools.Protocol.DOM.BackendNodeId? ViolatingNodeId { get; set; }

        public string? InvalidParameter { get; set; }
    }
}
