//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Runtime
{
    /// <summary>
    /// Call frames for assertions or error messages.
    /// </summary>
    public sealed class StackTrace
    {
        /// <summary>
        /// String label of this stack trace. For async traces this may be a name of the function that
        /// initiated the async call.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>JavaScript function name.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Runtime.CallFrame> CallFrames { get; set; }

        /// <summary>
        /// Asynchronous JavaScript stack trace that preceded this stack, if available.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.StackTrace? Parent { get; set; }

        /// <summary>
        /// [Experimental] Asynchronous JavaScript stack trace that preceded this stack, if available.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.StackTraceId? ParentId { get; set; }
    }
}
