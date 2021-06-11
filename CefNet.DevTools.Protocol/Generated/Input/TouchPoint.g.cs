//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Input
{
    public sealed class TouchPoint
    {
        /// <summary>
        /// X coordinate of the event relative to the main frame's viewport in CSS pixels.
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Y coordinate of the event relative to the main frame's viewport in CSS pixels. 0 refers to
        /// the top of the viewport and Y increases as it proceeds towards the bottom of the viewport.
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// X radius of the touch area (default: 1.0).
        /// </summary>
        public double? RadiusX { get; set; }

        /// <summary>
        /// Y radius of the touch area (default: 1.0).
        /// </summary>
        public double? RadiusY { get; set; }

        /// <summary>Rotation angle (default: 0.0).</summary>
        public double? RotationAngle { get; set; }

        /// <summary>Force (default: 1.0).</summary>
        public double? Force { get; set; }

        /// <summary>
        /// [Experimental] The normalized tangential pressure, which has a range of [-1,1] (default: 0).
        /// </summary>
        public double? TangentialPressure { get; set; }

        /// <summary>
        /// [Experimental] The plane angle between the Y-Z plane and the plane containing both the stylus axis and the Y axis, in degrees of the range [-90,90], a positive tiltX is to the right (default: 0)
        /// </summary>
        public int? TiltX { get; set; }

        /// <summary>
        /// [Experimental] The plane angle between the X-Z plane and the plane containing both the stylus axis and the X axis, in degrees of the range [-90,90], a positive tiltY is towards the user (default: 0).
        /// </summary>
        public int? TiltY { get; set; }

        /// <summary>
        /// [Experimental] The clockwise rotation of a pen stylus around its own major axis, in degrees in the range [0,359] (default: 0).
        /// </summary>
        public int? Twist { get; set; }

        /// <summary>
        /// Identifier used to track touch sources between events, must be unique within an event.
        /// </summary>
        public double? Id { get; set; }
    }
}
