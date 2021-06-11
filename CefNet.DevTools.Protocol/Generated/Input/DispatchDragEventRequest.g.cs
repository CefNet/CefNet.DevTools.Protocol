//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Input
{
    public sealed class DispatchDragEventRequest
    {
        /// <summary>Type of the drag event.</summary>
        public CefNet.DevTools.Protocol.Input.DispatchDragEventRequestType Type { get; set; }

        /// <summary>
        /// X coordinate of the event relative to the main frame's viewport in CSS pixels.
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Y coordinate of the event relative to the main frame's viewport in CSS pixels. 0 refers to
        /// the top of the viewport and Y increases as it proceeds towards the bottom of the viewport.
        /// </summary>
        public double Y { get; set; }

        public CefNet.DevTools.Protocol.Input.DragData Data { get; set; }

        /// <summary>
        /// Bit field representing pressed modifier keys. Alt=1, Ctrl=2, Meta/Command=4, Shift=8
        /// (default: 0).
        /// </summary>
        public int? Modifiers { get; set; }
    }
}
