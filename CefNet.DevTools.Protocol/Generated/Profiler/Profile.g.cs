//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Profiler
{
    /// <summary>Profile.</summary>
    public sealed class Profile
    {
        /// <summary>
        /// The list of profile nodes. First item is the root node.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Profiler.ProfileNode> Nodes { get; set; }

        /// <summary>
        /// Profiling start timestamp in microseconds.
        /// </summary>
        public double StartTime { get; set; }

        /// <summary>Profiling end timestamp in microseconds.</summary>
        public double EndTime { get; set; }

        /// <summary>Ids of samples top nodes.</summary>
        public System.Collections.Generic.List<int>? Samples { get; set; }

        /// <summary>
        /// Time intervals between adjacent samples in microseconds. The first delta is relative to the
        /// profile startTime.
        /// </summary>
        public System.Collections.Generic.List<int>? TimeDeltas { get; set; }
    }
}
