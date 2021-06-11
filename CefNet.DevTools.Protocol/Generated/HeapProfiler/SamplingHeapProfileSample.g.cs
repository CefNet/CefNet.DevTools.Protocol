//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.HeapProfiler
{
    /// <summary>A single sample from a sampling profile.</summary>
    public sealed class SamplingHeapProfileSample
    {
        /// <summary>
        /// Allocation size in bytes attributed to the sample.
        /// </summary>
        public double Size { get; set; }

        /// <summary>
        /// Id of the corresponding profile tree node.
        /// </summary>
        public int NodeId { get; set; }

        /// <summary>
        /// Time-ordered sample ordinal number. It is unique across all profiles retrieved
        /// between startSampling and stopSampling.
        /// </summary>
        public double Ordinal { get; set; }
    }
}
