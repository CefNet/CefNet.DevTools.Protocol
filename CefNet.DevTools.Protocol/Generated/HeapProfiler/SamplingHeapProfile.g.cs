//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.HeapProfiler
{
    /// <summary>Sampling profile.</summary>
    public sealed class SamplingHeapProfile
    {
        public CefNet.DevTools.Protocol.HeapProfiler.SamplingHeapProfileNode Head { get; set; }

        public System.Collections.Generic.List<CefNet.DevTools.Protocol.HeapProfiler.SamplingHeapProfileSample> Samples { get; set; }
    }
}
