//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOMDebugger
{
    public sealed class RemoveDOMBreakpointRequest
    {
        /// <summary>
        /// Identifier of the node to remove breakpoint from.
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.NodeId NodeId { get; set; }

        /// <summary>Type of the breakpoint to remove.</summary>
        public CefNet.DevTools.Protocol.DOMDebugger.DOMBreakpointType Type { get; set; }
    }
}
