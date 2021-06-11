//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Overlay
{
    /// <summary>Configuration for dual screen hinge</summary>
    public sealed class HingeConfig
    {
        /// <summary>A rectangle represent hinge</summary>
        public CefNet.DevTools.Protocol.DOM.Rect Rect { get; set; }

        /// <summary>
        /// The content box highlight fill color (default: a dark color).
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.RGBA? ContentColor { get; set; }

        /// <summary>
        /// The content box highlight outline color (default: transparent).
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.RGBA? OutlineColor { get; set; }
    }
}
