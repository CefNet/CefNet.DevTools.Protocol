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
    /// An inspector issue reported from the back-end.
    /// </summary>
    public sealed class InspectorIssue
    {
        public CefNet.DevTools.Protocol.Audits.InspectorIssueCode Code { get; set; }

        public CefNet.DevTools.Protocol.Audits.InspectorIssueDetails Details { get; set; }

        /// <summary>
        /// A unique id for this issue. May be omitted if no other entity (e.g.
        /// exception, CDP message, etc.) is referencing this issue.
        /// </summary>
        public string? IssueId { get; set; }
    }
}
