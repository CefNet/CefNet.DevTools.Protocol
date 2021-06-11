//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Debugger
{
    public sealed class SetBreakpointByUrlResponse
    {
        /// <summary>
        /// Id of the created breakpoint for further reference.
        /// </summary>
        public CefNet.DevTools.Protocol.Debugger.BreakpointId BreakpointId { get; set; }

        /// <summary>
        /// List of the locations this breakpoint resolved into upon addition.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Debugger.Location> Locations { get; set; }
    }
}
