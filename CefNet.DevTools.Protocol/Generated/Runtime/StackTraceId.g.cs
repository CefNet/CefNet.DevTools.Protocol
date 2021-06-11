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
    /// [Experimental] If `debuggerId` is set stack trace comes from another debugger and can be resolved there. This
    /// allows to track cross-debugger calls. See `Runtime.StackTrace` and `Debugger.paused` for usages.
    /// </summary>
    public sealed class StackTraceId
    {
        public string Id { get; set; }

        public CefNet.DevTools.Protocol.Runtime.UniqueDebuggerId? DebuggerId { get; set; }
    }
}
