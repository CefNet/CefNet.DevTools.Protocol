//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Input
{
    public sealed class EmulateTouchFromMouseEventRequest
    {
        /// <summary>Type of the mouse event.</summary>
        public CefNet.DevTools.Protocol.Input.EmulateTouchFromMouseEventRequestType Type { get; set; }

        /// <summary>
        /// X coordinate of the mouse pointer in DIP.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Y coordinate of the mouse pointer in DIP.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Mouse button. Only "none", "left", "right" are supported.
        /// </summary>
        public CefNet.DevTools.Protocol.Input.MouseButton Button { get; set; }

        /// <summary>
        /// Time at which the event occurred (default: current time).
        /// </summary>
        public CefNet.DevTools.Protocol.Input.TimeSinceEpoch? Timestamp { get; set; }

        /// <summary>
        /// X delta in DIP for mouse wheel event (default: 0).
        /// </summary>
        public double? DeltaX { get; set; }

        /// <summary>
        /// Y delta in DIP for mouse wheel event (default: 0).
        /// </summary>
        public double? DeltaY { get; set; }

        /// <summary>
        /// Bit field representing pressed modifier keys. Alt=1, Ctrl=2, Meta/Command=4, Shift=8
        /// (default: 0).
        /// </summary>
        public int? Modifiers { get; set; }

        /// <summary>
        /// Number of times the mouse button was clicked (default: 0).
        /// </summary>
        public int? ClickCount { get; set; }
    }
}
