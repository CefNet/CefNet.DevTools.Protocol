//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Memory
{
    public sealed class StartSamplingRequest
    {
        /// <summary>Average number of bytes between samples.</summary>
        public int? SamplingInterval { get; set; }

        /// <summary>
        /// Do not randomize intervals between samples.
        /// </summary>
        public bool? SuppressRandomness { get; set; }
    }
}
