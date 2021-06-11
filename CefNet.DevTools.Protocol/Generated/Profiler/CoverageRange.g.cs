//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Profiler
{
    /// <summary>Coverage data for a source range.</summary>
    public sealed class CoverageRange
    {
        /// <summary>
        /// JavaScript script source offset for the range start.
        /// </summary>
        public int StartOffset { get; set; }

        /// <summary>
        /// JavaScript script source offset for the range end.
        /// </summary>
        public int EndOffset { get; set; }

        /// <summary>
        /// Collected execution count of the source range.
        /// </summary>
        public int Count { get; set; }
    }
}
