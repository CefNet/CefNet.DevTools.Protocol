//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Debugger
{
    public sealed class RestartFrameResponse
    {
        /// <summary>New stack trace.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Debugger.CallFrame> CallFrames { get; set; }

        /// <summary>Async stack trace, if any.</summary>
        public CefNet.DevTools.Protocol.Runtime.StackTrace? AsyncStackTrace { get; set; }

        /// <summary>
        /// [Experimental] Async stack trace, if any.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.StackTraceId? AsyncStackTraceId { get; set; }
    }
}
