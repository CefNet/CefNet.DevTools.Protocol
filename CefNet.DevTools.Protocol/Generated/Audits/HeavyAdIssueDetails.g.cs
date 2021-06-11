//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Audits
{
    public sealed class HeavyAdIssueDetails
    {
        /// <summary>
        /// The resolution status, either blocking the content or warning.
        /// </summary>
        public CefNet.DevTools.Protocol.Audits.HeavyAdResolutionStatus Resolution { get; set; }

        /// <summary>
        /// The reason the ad was blocked, total network or cpu or peak cpu.
        /// </summary>
        public CefNet.DevTools.Protocol.Audits.HeavyAdReason Reason { get; set; }

        /// <summary>The frame that was blocked.</summary>
        public CefNet.DevTools.Protocol.Audits.AffectedFrame Frame { get; set; }
    }
}
