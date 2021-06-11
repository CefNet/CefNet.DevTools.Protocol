//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Overlay
{
    /// <summary>
    /// Configuration data for the highlighting of page elements.
    /// </summary>
    public sealed class HighlightConfig
    {
        /// <summary>
        /// Whether the node info tooltip should be shown (default: false).
        /// </summary>
        public bool? ShowInfo { get; set; }

        /// <summary>
        /// Whether the node styles in the tooltip (default: false).
        /// </summary>
        public bool? ShowStyles { get; set; }

        /// <summary>
        /// Whether the rulers should be shown (default: false).
        /// </summary>
        public bool? ShowRulers { get; set; }

        /// <summary>
        /// Whether the a11y info should be shown (default: true).
        /// </summary>
        public bool? ShowAccessibilityInfo { get; set; }

        /// <summary>
        /// Whether the extension lines from node to the rulers should be shown (default: false).
        /// </summary>
        public bool? ShowExtensionLines { get; set; }

        /// <summary>
        /// The content box highlight fill color (default: transparent).
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.RGBA? ContentColor { get; set; }

        /// <summary>
        /// The padding highlight fill color (default: transparent).
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.RGBA? PaddingColor { get; set; }

        /// <summary>
        /// The border highlight fill color (default: transparent).
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.RGBA? BorderColor { get; set; }

        /// <summary>
        /// The margin highlight fill color (default: transparent).
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.RGBA? MarginColor { get; set; }

        /// <summary>
        /// The event target element highlight fill color (default: transparent).
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.RGBA? EventTargetColor { get; set; }

        /// <summary>
        /// The shape outside fill color (default: transparent).
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.RGBA? ShapeColor { get; set; }

        /// <summary>
        /// The shape margin fill color (default: transparent).
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.RGBA? ShapeMarginColor { get; set; }

        /// <summary>
        /// The grid layout color (default: transparent).
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.RGBA? CssGridColor { get; set; }

        /// <summary>
        /// The color format used to format color styles (default: hex).
        /// </summary>
        public CefNet.DevTools.Protocol.Overlay.ColorFormat? ColorFormat { get; set; }

        /// <summary>
        /// The grid layout highlight configuration (default: all transparent).
        /// </summary>
        public CefNet.DevTools.Protocol.Overlay.GridHighlightConfig? GridHighlightConfig { get; set; }

        /// <summary>
        /// The flex container highlight configuration (default: all transparent).
        /// </summary>
        public CefNet.DevTools.Protocol.Overlay.FlexContainerHighlightConfig? FlexContainerHighlightConfig { get; set; }

        /// <summary>
        /// The flex item highlight configuration (default: all transparent).
        /// </summary>
        public CefNet.DevTools.Protocol.Overlay.FlexItemHighlightConfig? FlexItemHighlightConfig { get; set; }

        /// <summary>
        /// The contrast algorithm to use for the contrast ratio (default: aa).
        /// </summary>
        public CefNet.DevTools.Protocol.Overlay.ContrastAlgorithm? ContrastAlgorithm { get; set; }
    }
}
