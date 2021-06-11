//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Debugger
{
    public sealed class PausedEventArgs
        : System.EventArgs
    {
        /// <summary>
        /// Call stack the virtual machine stopped on.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Debugger.CallFrame> CallFrames { get; set; }

        /// <summary>Pause reason.</summary>
        public CefNet.DevTools.Protocol.Debugger.PausedEventArgsReason Reason { get; set; }

        /// <summary>
        /// Object containing break-specific auxiliary properties.
        /// </summary>
        public System.Collections.Generic.Dictionary<string, object>? Data { get; set; }

        /// <summary>Hit breakpoints IDs</summary>
        public System.Collections.Generic.List<string>? HitBreakpoints { get; set; }

        /// <summary>Async stack trace, if any.</summary>
        public CefNet.DevTools.Protocol.Runtime.StackTrace? AsyncStackTrace { get; set; }

        /// <summary>
        /// [Experimental] Async stack trace, if any.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.StackTraceId? AsyncStackTraceId { get; set; }

        /// <summary>
        /// [Deprecated] [Experimental] Never present, will be removed.
        /// </summary>
        [Obsolete]
        public CefNet.DevTools.Protocol.Runtime.StackTraceId? AsyncCallStackTraceId { get; set; }
    }
}
