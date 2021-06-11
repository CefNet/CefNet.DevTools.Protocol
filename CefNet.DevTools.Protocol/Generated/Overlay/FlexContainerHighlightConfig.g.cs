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
    /// Configuration data for the highlighting of Flex container elements.
    /// </summary>
    public sealed class FlexContainerHighlightConfig
    {
        /// <summary>The style of the container border</summary>
        public CefNet.DevTools.Protocol.Overlay.LineStyle? ContainerBorder { get; set; }

        /// <summary>The style of the separator between lines</summary>
        public CefNet.DevTools.Protocol.Overlay.LineStyle? LineSeparator { get; set; }

        /// <summary>The style of the separator between items</summary>
        public CefNet.DevTools.Protocol.Overlay.LineStyle? ItemSeparator { get; set; }

        /// <summary>
        /// Style of content-distribution space on the main axis (justify-content).
        /// </summary>
        public CefNet.DevTools.Protocol.Overlay.BoxStyle? MainDistributedSpace { get; set; }

        /// <summary>
        /// Style of content-distribution space on the cross axis (align-content).
        /// </summary>
        public CefNet.DevTools.Protocol.Overlay.BoxStyle? CrossDistributedSpace { get; set; }

        /// <summary>
        /// Style of empty space caused by row gaps (gap/row-gap).
        /// </summary>
        public CefNet.DevTools.Protocol.Overlay.BoxStyle? RowGapSpace { get; set; }

        /// <summary>
        /// Style of empty space caused by columns gaps (gap/column-gap).
        /// </summary>
        public CefNet.DevTools.Protocol.Overlay.BoxStyle? ColumnGapSpace { get; set; }

        /// <summary>
        /// Style of the self-alignment line (align-items).
        /// </summary>
        public CefNet.DevTools.Protocol.Overlay.LineStyle? CrossAlignment { get; set; }
    }
}
