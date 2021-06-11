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
    /// Configuration data for the highlighting of Grid elements.
    /// </summary>
    public sealed class GridHighlightConfig
    {
        /// <summary>
        /// Whether the extension lines from grid cells to the rulers should be shown (default: false).
        /// </summary>
        public bool? ShowGridExtensionLines { get; set; }

        /// <summary>
        /// Show Positive line number labels (default: false).
        /// </summary>
        public bool? ShowPositiveLineNumbers { get; set; }

        /// <summary>
        /// Show Negative line number labels (default: false).
        /// </summary>
        public bool? ShowNegativeLineNumbers { get; set; }

        /// <summary>Show area name labels (default: false).</summary>
        public bool? ShowAreaNames { get; set; }

        /// <summary>Show line name labels (default: false).</summary>
        public bool? ShowLineNames { get; set; }

        /// <summary>Show track size labels (default: false).</summary>
        public bool? ShowTrackSizes { get; set; }

        /// <summary>
        /// The grid container border highlight color (default: transparent).
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.RGBA? GridBorderColor { get; set; }

        /// <summary>
        /// [Deprecated] The cell border color (default: transparent). Deprecated, please use rowLineColor and columnLineColor instead.
        /// </summary>
        [Obsolete]
        public CefNet.DevTools.Protocol.DOM.RGBA? CellBorderColor { get; set; }

        /// <summary>
        /// The row line color (default: transparent).
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.RGBA? RowLineColor { get; set; }

        /// <summary>
        /// The column line color (default: transparent).
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.RGBA? ColumnLineColor { get; set; }

        /// <summary>
        /// Whether the grid border is dashed (default: false).
        /// </summary>
        public bool? GridBorderDash { get; set; }

        /// <summary>
        /// [Deprecated] Whether the cell border is dashed (default: false). Deprecated, please us rowLineDash and columnLineDash instead.
        /// </summary>
        [Obsolete]
        public bool? CellBorderDash { get; set; }

        /// <summary>
        /// Whether row lines are dashed (default: false).
        /// </summary>
        public bool? RowLineDash { get; set; }

        /// <summary>
        /// Whether column lines are dashed (default: false).
        /// </summary>
        public bool? ColumnLineDash { get; set; }

        /// <summary>
        /// The row gap highlight fill color (default: transparent).
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.RGBA? RowGapColor { get; set; }

        /// <summary>
        /// The row gap hatching fill color (default: transparent).
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.RGBA? RowHatchColor { get; set; }

        /// <summary>
        /// The column gap highlight fill color (default: transparent).
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.RGBA? ColumnGapColor { get; set; }

        /// <summary>
        /// The column gap hatching fill color (default: transparent).
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.RGBA? ColumnHatchColor { get; set; }

        /// <summary>
        /// The named grid areas border color (Default: transparent).
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.RGBA? AreaBorderColor { get; set; }

        /// <summary>
        /// The grid container background color (Default: transparent).
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.RGBA? GridBackgroundColor { get; set; }
    }
}
