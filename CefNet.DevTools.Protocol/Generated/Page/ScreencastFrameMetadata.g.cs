//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    /// <summary>
    /// [Experimental] Screencast frame metadata.
    /// </summary>
    public sealed class ScreencastFrameMetadata
    {
        /// <summary>Top offset in DIP.</summary>
        public double OffsetTop { get; set; }

        /// <summary>Page scale factor.</summary>
        public double PageScaleFactor { get; set; }

        /// <summary>Device screen width in DIP.</summary>
        public double DeviceWidth { get; set; }

        /// <summary>Device screen height in DIP.</summary>
        public double DeviceHeight { get; set; }

        /// <summary>
        /// Position of horizontal scroll in CSS pixels.
        /// </summary>
        public double ScrollOffsetX { get; set; }

        /// <summary>
        /// Position of vertical scroll in CSS pixels.
        /// </summary>
        public double ScrollOffsetY { get; set; }

        /// <summary>Frame swap timestamp.</summary>
        public CefNet.DevTools.Protocol.Network.TimeSinceEpoch? Timestamp { get; set; }
    }
}
