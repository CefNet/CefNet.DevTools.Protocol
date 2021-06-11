//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Tracing
{
    public sealed class TracingCompleteEventArgs
        : System.EventArgs
    {
        /// <summary>
        /// Indicates whether some trace data is known to have been lost, e.g. because the trace ring
        /// buffer wrapped around.
        /// </summary>
        public bool DataLossOccurred { get; set; }

        /// <summary>
        /// A handle of the stream that holds resulting trace data.
        /// </summary>
        public CefNet.DevTools.Protocol.IO.StreamHandle? Stream { get; set; }

        /// <summary>Trace data format of returned stream.</summary>
        public CefNet.DevTools.Protocol.Tracing.StreamFormat? TraceFormat { get; set; }

        /// <summary>Compression format of returned stream.</summary>
        public CefNet.DevTools.Protocol.Tracing.StreamCompression? StreamCompression { get; set; }
    }
}
