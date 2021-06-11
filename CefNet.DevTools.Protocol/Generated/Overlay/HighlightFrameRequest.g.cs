//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Overlay
{
    public sealed class HighlightFrameRequest
    {
        /// <summary>Identifier of the frame to highlight.</summary>
        public CefNet.DevTools.Protocol.Page.FrameId FrameId { get; set; }

        /// <summary>
        /// The content box highlight fill color (default: transparent).
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.RGBA? ContentColor { get; set; }

        /// <summary>
        /// The content box highlight outline color (default: transparent).
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.RGBA? ContentOutlineColor { get; set; }
    }
}
