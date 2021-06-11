//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Tracing
{
    public sealed class RequestMemoryDumpRequest
    {
        /// <summary>
        /// Enables more deterministic results by forcing garbage collection
        /// </summary>
        public bool? Deterministic { get; set; }

        /// <summary>
        /// Specifies level of details in memory dump. Defaults to "detailed".
        /// </summary>
        public CefNet.DevTools.Protocol.Tracing.MemoryDumpLevelOfDetail? LevelOfDetail { get; set; }
    }
}
