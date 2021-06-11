//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOMDebugger
{
    public sealed class SetEventListenerBreakpointRequest
    {
        /// <summary>
        /// DOM Event name to stop on (any DOM event will do).
        /// </summary>
        public string EventName { get; set; }

        /// <summary>
        /// [Experimental] EventTarget interface name to stop on. If equal to `"*"` or not provided, will stop on any
        /// EventTarget.
        /// </summary>
        public string? TargetName { get; set; }
    }
}
