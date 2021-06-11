//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Debugger
{
    public sealed class SetBreakpointOnFunctionCallRequest
    {
        /// <summary>Function object id.</summary>
        public CefNet.DevTools.Protocol.Runtime.RemoteObjectId ObjectId { get; set; }

        /// <summary>
        /// Expression to use as a breakpoint condition. When specified, debugger will
        /// stop on the breakpoint if this expression evaluates to true.
        /// </summary>
        public string? Condition { get; set; }
    }
}
