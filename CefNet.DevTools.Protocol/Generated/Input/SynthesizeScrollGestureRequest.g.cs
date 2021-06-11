//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Input
{
    public sealed class SynthesizeScrollGestureRequest
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
        /// The distance to scroll along the X axis (positive to scroll left).
        /// </summary>
        public double? XDistance { get; set; }

        /// <summary>
        /// The distance to scroll along the Y axis (positive to scroll up).
        /// </summary>
        public double? YDistance { get; set; }

        /// <summary>
        /// The number of additional pixels to scroll back along the X axis, in addition to the given
        /// distance.
        /// </summary>
        public double? XOverscroll { get; set; }

        /// <summary>
        /// The number of additional pixels to scroll back along the Y axis, in addition to the given
        /// distance.
        /// </summary>
        public double? YOverscroll { get; set; }

        /// <summary>Prevent fling (default: true).</summary>
        public bool? PreventFling { get; set; }

        /// <summary>
        /// Swipe speed in pixels per second (default: 800).
        /// </summary>
        public int? Speed { get; set; }

        /// <summary>
        /// Which type of input events to be generated (default: 'default', which queries the platform
        /// for the preferred input type).
        /// </summary>
        public CefNet.DevTools.Protocol.Input.GestureSourceType? GestureSourceType { get; set; }

        /// <summary>
        /// The number of times to repeat the gesture (default: 0).
        /// </summary>
        public int? RepeatCount { get; set; }

        /// <summary>
        /// The number of milliseconds delay between each repeat. (default: 250).
        /// </summary>
        public int? RepeatDelayMs { get; set; }

        /// <summary>
        /// The name of the interaction markers to generate, if not empty (default: "").
        /// </summary>
        public string? InteractionMarkerName { get; set; }
    }
}
