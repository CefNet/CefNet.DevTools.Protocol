//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Input
{
    public sealed class DispatchTouchEventRequest
    {
        /// <summary>
        /// Type of the touch event. TouchEnd and TouchCancel must not contain any touch points, while
        /// TouchStart and TouchMove must contains at least one.
        /// </summary>
        public CefNet.DevTools.Protocol.Input.DispatchTouchEventRequestType Type { get; set; }

        /// <summary>
        /// Active touch points on the touch device. One event per any changed point (compared to
        /// previous touch event in a sequence) is generated, emulating pressing/moving/releasing points
        /// one by one.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Input.TouchPoint> TouchPoints { get; set; }

        /// <summary>
        /// Bit field representing pressed modifier keys. Alt=1, Ctrl=2, Meta/Command=4, Shift=8
        /// (default: 0).
        /// </summary>
        public int? Modifiers { get; set; }

        /// <summary>Time at which the event occurred.</summary>
        public CefNet.DevTools.Protocol.Input.TimeSinceEpoch? Timestamp { get; set; }
    }
}
