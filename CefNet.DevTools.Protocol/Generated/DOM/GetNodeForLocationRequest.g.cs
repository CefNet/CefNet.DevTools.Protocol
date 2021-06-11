//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOM
{
    public sealed class GetNodeForLocationRequest
    {
        /// <summary>X coordinate.</summary>
        public int X { get; set; }

        /// <summary>Y coordinate.</summary>
        public int Y { get; set; }

        /// <summary>
        /// False to skip to the nearest non-UA shadow root ancestor (default: false).
        /// </summary>
        public bool? IncludeUserAgentShadowDOM { get; set; }

        /// <summary>
        /// Whether to ignore pointer-events: none on elements and hit test them.
        /// </summary>
        public bool? IgnorePointerEventsNone { get; set; }
    }
}
