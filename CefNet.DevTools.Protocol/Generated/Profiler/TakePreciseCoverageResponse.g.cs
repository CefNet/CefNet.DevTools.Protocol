//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Profiler
{
    public sealed class TakePreciseCoverageResponse
    {
        /// <summary>Coverage data for the current isolate.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Profiler.ScriptCoverage> Result { get; set; }

        /// <summary>
        /// Monotonically increasing time (in seconds) when the coverage update was taken in the backend.
        /// </summary>
        public double Timestamp { get; set; }
    }
}
