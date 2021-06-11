//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.HeapProfiler
{
    public sealed class StartSamplingRequest
    {
        /// <summary>
        /// Average sample interval in bytes. Poisson distribution is used for the intervals. The
        /// default value is 32768 bytes.
        /// </summary>
        public double? SamplingInterval { get; set; }
    }
}
