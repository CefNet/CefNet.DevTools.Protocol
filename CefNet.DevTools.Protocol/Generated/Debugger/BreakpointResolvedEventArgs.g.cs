//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Debugger
{
    public sealed class BreakpointResolvedEventArgs
        : System.EventArgs
    {
        /// <summary>Breakpoint unique identifier.</summary>
        public CefNet.DevTools.Protocol.Debugger.BreakpointId BreakpointId { get; set; }

        /// <summary>Actual breakpoint location.</summary>
        public CefNet.DevTools.Protocol.Debugger.Location Location { get; set; }
    }
}
