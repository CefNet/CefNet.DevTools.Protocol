//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Tracing
{
    public sealed class TraceConfig
    {
        /// <summary>
        /// Controls how the trace buffer stores data.
        /// </summary>
        public CefNet.DevTools.Protocol.Tracing.TraceConfigRecordMode? RecordMode { get; set; }

        /// <summary>Turns on JavaScript stack sampling.</summary>
        public bool? EnableSampling { get; set; }

        /// <summary>Turns on system tracing.</summary>
        public bool? EnableSystrace { get; set; }

        /// <summary>Turns on argument filter.</summary>
        public bool? EnableArgumentFilter { get; set; }

        /// <summary>Included category filters.</summary>
        public System.Collections.Generic.List<string>? IncludedCategories { get; set; }

        /// <summary>Excluded category filters.</summary>
        public System.Collections.Generic.List<string>? ExcludedCategories { get; set; }

        /// <summary>
        /// Configuration to synthesize the delays in tracing.
        /// </summary>
        public System.Collections.Generic.List<string>? SyntheticDelays { get; set; }

        /// <summary>
        /// Configuration for memory dump triggers. Used only when "memory-infra" category is enabled.
        /// </summary>
        public CefNet.DevTools.Protocol.Tracing.MemoryDumpConfig? MemoryDumpConfig { get; set; }
    }
}
