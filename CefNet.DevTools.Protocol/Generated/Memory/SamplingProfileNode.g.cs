//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Memory
{
    /// <summary>Heap profile sample.</summary>
    public sealed class SamplingProfileNode
    {
        /// <summary>Size of the sampled allocation.</summary>
        public double Size { get; set; }

        /// <summary>Total bytes attributed to this sample.</summary>
        public double Total { get; set; }

        /// <summary>
        /// Execution stack at the point of allocation.
        /// </summary>
        public System.Collections.Generic.List<string> Stack { get; set; }
    }
}
