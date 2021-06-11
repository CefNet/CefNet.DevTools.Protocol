//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    public sealed class GetLayoutMetricsResponse
    {
        /// <summary>
        /// [Deprecated] Deprecated metrics relating to the layout viewport. Can be in DP or in CSS pixels depending on the `enable-use-zoom-for-dsf` flag. Use `cssLayoutViewport` instead.
        /// </summary>
        [Obsolete]
        public CefNet.DevTools.Protocol.Page.LayoutViewport LayoutViewport { get; set; }

        /// <summary>
        /// [Deprecated] Deprecated metrics relating to the visual viewport. Can be in DP or in CSS pixels depending on the `enable-use-zoom-for-dsf` flag. Use `cssVisualViewport` instead.
        /// </summary>
        [Obsolete]
        public CefNet.DevTools.Protocol.Page.VisualViewport VisualViewport { get; set; }

        /// <summary>
        /// [Deprecated] Deprecated size of scrollable area. Can be in DP or in CSS pixels depending on the `enable-use-zoom-for-dsf` flag. Use `cssContentSize` instead.
        /// </summary>
        [Obsolete]
        public CefNet.DevTools.Protocol.DOM.Rect ContentSize { get; set; }

        /// <summary>
        /// Metrics relating to the layout viewport in CSS pixels.
        /// </summary>
        public CefNet.DevTools.Protocol.Page.LayoutViewport CssLayoutViewport { get; set; }

        /// <summary>
        /// Metrics relating to the visual viewport in CSS pixels.
        /// </summary>
        public CefNet.DevTools.Protocol.Page.VisualViewport CssVisualViewport { get; set; }

        /// <summary>Size of scrollable area in CSS pixels.</summary>
        public CefNet.DevTools.Protocol.DOM.Rect CssContentSize { get; set; }
    }
}
