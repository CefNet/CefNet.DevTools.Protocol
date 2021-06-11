//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Tracing
{
    public sealed class BufferUsageEventArgs
        : System.EventArgs
    {
        /// <summary>
        /// A number in range [0..1] that indicates the used size of event buffer as a fraction of its
        /// total size.
        /// </summary>
        public double? PercentFull { get; set; }

        /// <summary>
        /// An approximate number of events in the trace log.
        /// </summary>
        public double? EventCount { get; set; }

        /// <summary>
        /// A number in range [0..1] that indicates the used size of event buffer as a fraction of its
        /// total size.
        /// </summary>
        public double? Value { get; set; }
    }
}
