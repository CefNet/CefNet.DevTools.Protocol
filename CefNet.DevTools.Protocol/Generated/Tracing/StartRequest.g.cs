//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Tracing
{
    public sealed class StartRequest
    {
        /// <summary>[Deprecated] Category/tag filter</summary>
        [Obsolete]
        public string? Categories { get; set; }

        /// <summary>[Deprecated] Tracing options</summary>
        [Obsolete]
        public string? Options { get; set; }

        /// <summary>
        /// If set, the agent will issue bufferUsage events at this interval, specified in milliseconds
        /// </summary>
        public double? BufferUsageReportingInterval { get; set; }

        /// <summary>
        /// Whether to report trace events as series of dataCollected events or to save trace to a
        /// stream (defaults to `ReportEvents`).
        /// </summary>
        public CefNet.DevTools.Protocol.Tracing.StartRequestTransferMode? TransferMode { get; set; }

        /// <summary>
        /// Trace data format to use. This only applies when using `ReturnAsStream`
        /// transfer mode (defaults to `json`).
        /// </summary>
        public CefNet.DevTools.Protocol.Tracing.StreamFormat? StreamFormat { get; set; }

        /// <summary>
        /// Compression format to use. This only applies when using `ReturnAsStream`
        /// transfer mode (defaults to `none`)
        /// </summary>
        public CefNet.DevTools.Protocol.Tracing.StreamCompression? StreamCompression { get; set; }

        public CefNet.DevTools.Protocol.Tracing.TraceConfig? TraceConfig { get; set; }

        /// <summary>
        /// Base64-encoded serialized perfetto.protos.TraceConfig protobuf message
        /// When specified, the parameters `categories`, `options`, `traceConfig`
        /// are ignored.
        /// </summary>
        public byte[]? PerfettoConfig { get; set; }

        /// <summary>Backend type (defaults to `auto`)</summary>
        public CefNet.DevTools.Protocol.Tracing.TracingBackend? TracingBackend { get; set; }
    }
}
