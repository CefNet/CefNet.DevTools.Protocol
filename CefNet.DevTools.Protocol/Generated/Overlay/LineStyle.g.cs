//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Overlay
{
    /// <summary>Style information for drawing a line.</summary>
    public sealed class LineStyle
    {
        /// <summary>
        /// The color of the line (default: transparent)
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.RGBA? Color { get; set; }

        /// <summary>The line pattern (default: solid)</summary>
        public CefNet.DevTools.Protocol.Overlay.LineStylePattern? Pattern { get; set; }
    }
}
