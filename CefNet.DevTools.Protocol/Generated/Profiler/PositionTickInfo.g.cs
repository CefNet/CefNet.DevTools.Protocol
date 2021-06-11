//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Profiler
{
    /// <summary>
    /// Specifies a number of samples attributed to a certain source position.
    /// </summary>
    public sealed class PositionTickInfo
    {
        /// <summary>Source line number (1-based).</summary>
        public int Line { get; set; }

        /// <summary>
        /// Number of samples attributed to the source line.
        /// </summary>
        public int Ticks { get; set; }
    }
}
