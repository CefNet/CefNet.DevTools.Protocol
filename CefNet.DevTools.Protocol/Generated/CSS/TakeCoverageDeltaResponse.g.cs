//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.CSS
{
    public sealed class TakeCoverageDeltaResponse
    {
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.CSS.RuleUsage> Coverage { get; set; }

        /// <summary>
        /// Monotonically increasing time, in seconds.
        /// </summary>
        public double Timestamp { get; set; }
    }
}
