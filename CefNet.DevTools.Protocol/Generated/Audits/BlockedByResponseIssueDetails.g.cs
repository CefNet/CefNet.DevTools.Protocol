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
    /// Details for a request that has been blocked with the BLOCKED_BY_RESPONSE
    /// code. Currently only used for COEP/COOP, but may be extended to include
    /// some CSP errors in the future.
    /// </summary>
    public sealed class BlockedByResponseIssueDetails
    {
        public CefNet.DevTools.Protocol.Audits.AffectedRequest Request { get; set; }

        public CefNet.DevTools.Protocol.Audits.AffectedFrame? ParentFrame { get; set; }

        public CefNet.DevTools.Protocol.Audits.AffectedFrame? BlockedFrame { get; set; }

        public CefNet.DevTools.Protocol.Audits.BlockedByResponseReason Reason { get; set; }
    }
}
