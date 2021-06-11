//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Overlay
{
    public sealed class ScrollSnapContainerHighlightConfig
    {
        /// <summary>
        /// The style of the snapport border (default: transparent)
        /// </summary>
        public CefNet.DevTools.Protocol.Overlay.LineStyle? SnapportBorder { get; set; }

        /// <summary>
        /// The style of the snap area border (default: transparent)
        /// </summary>
        public CefNet.DevTools.Protocol.Overlay.LineStyle? SnapAreaBorder { get; set; }

        /// <summary>
        /// The margin highlight fill color (default: transparent).
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.RGBA? ScrollMarginColor { get; set; }

        /// <summary>
        /// The padding highlight fill color (default: transparent).
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.RGBA? ScrollPaddingColor { get; set; }
    }
}
