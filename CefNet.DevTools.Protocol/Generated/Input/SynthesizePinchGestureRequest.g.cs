//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Input
{
    public sealed class SynthesizePinchGestureRequest
    {
        /// <summary>
        /// X coordinate of the start of the gesture in CSS pixels.
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Y coordinate of the start of the gesture in CSS pixels.
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Relative scale factor after zooming (>1.0 zooms in, <1.0 zooms out).
        /// </summary>
        public double ScaleFactor { get; set; }

        /// <summary>
        /// Relative pointer speed in pixels per second (default: 800).
        /// </summary>
        public int? RelativeSpeed { get; set; }

        /// <summary>
        /// Which type of input events to be generated (default: 'default', which queries the platform
        /// for the preferred input type).
        /// </summary>
        public CefNet.DevTools.Protocol.Input.GestureSourceType? GestureSourceType { get; set; }
    }
}
