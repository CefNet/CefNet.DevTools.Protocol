//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.HeapProfiler
{
    /// <summary>
    /// Sampling Heap Profile node. Holds callsite information, allocation statistics and child nodes.
    /// </summary>
    public sealed class SamplingHeapProfileNode
    {
        /// <summary>Function location.</summary>
        public CefNet.DevTools.Protocol.Runtime.CallFrame CallFrame { get; set; }

        /// <summary>
        /// Allocations size in bytes for the node excluding children.
        /// </summary>
        public double SelfSize { get; set; }

        /// <summary>
        /// Node id. Ids are unique across all profiles collected between startSampling and stopSampling.
        /// </summary>
        public int Id { get; set; }

        /// <summary>Child nodes.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.HeapProfiler.SamplingHeapProfileNode> Children { get; set; }
    }
}
