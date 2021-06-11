//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Debugger
{
    public sealed class GetPossibleBreakpointsRequest
    {
        /// <summary>
        /// Start of range to search possible breakpoint locations in.
        /// </summary>
        public CefNet.DevTools.Protocol.Debugger.Location Start { get; set; }

        /// <summary>
        /// End of range to search possible breakpoint locations in (excluding). When not specified, end
        /// of scripts is used as end of range.
        /// </summary>
        public CefNet.DevTools.Protocol.Debugger.Location? End { get; set; }

        /// <summary>
        /// Only consider locations which are in the same (non-nested) function as start.
        /// </summary>
        public bool? RestrictToFunction { get; set; }
    }
}
