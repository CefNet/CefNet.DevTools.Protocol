//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Overlay
{
    public sealed class HighlightQuadRequest
    {
        /// <summary>Quad to highlight</summary>
        public CefNet.DevTools.Protocol.DOM.Quad Quad { get; set; }

        /// <summary>
        /// The highlight fill color (default: transparent).
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.RGBA? Color { get; set; }

        /// <summary>
        /// The highlight outline color (default: transparent).
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.RGBA? OutlineColor { get; set; }
    }
}
