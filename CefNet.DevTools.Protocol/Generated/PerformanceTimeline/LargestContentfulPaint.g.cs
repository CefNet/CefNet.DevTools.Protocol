//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.PerformanceTimeline
{
    /// <summary>
    /// See https://github.com/WICG/LargestContentfulPaint and largest_contentful_paint.idl
    /// </summary>
    public sealed class LargestContentfulPaint
    {
        public CefNet.DevTools.Protocol.Network.TimeSinceEpoch RenderTime { get; set; }

        public CefNet.DevTools.Protocol.Network.TimeSinceEpoch LoadTime { get; set; }

        /// <summary>The number of pixels being painted.</summary>
        public double Size { get; set; }

        /// <summary>
        /// The id attribute of the element, if available.
        /// </summary>
        public string? ElementId { get; set; }

        /// <summary>The URL of the image (may be trimmed).</summary>
        public string? Url { get; set; }

        public CefNet.DevTools.Protocol.DOM.BackendNodeId? NodeId { get; set; }
    }
}
