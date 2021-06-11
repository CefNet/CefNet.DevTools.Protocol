//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Input
{
    public sealed class SynthesizeTapGestureRequest
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
        /// Duration between touchdown and touchup events in ms (default: 50).
        /// </summary>
        public int? Duration { get; set; }

        /// <summary>
        /// Number of times to perform the tap (e.g. 2 for double tap, default: 1).
        /// </summary>
        public int? TapCount { get; set; }

        /// <summary>
        /// Which type of input events to be generated (default: 'default', which queries the platform
        /// for the preferred input type).
        /// </summary>
        public CefNet.DevTools.Protocol.Input.GestureSourceType? GestureSourceType { get; set; }
    }
}
