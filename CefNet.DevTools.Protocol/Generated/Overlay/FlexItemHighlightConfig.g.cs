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
    /// Configuration data for the highlighting of Flex item elements.
    /// </summary>
    public sealed class FlexItemHighlightConfig
    {
        /// <summary>
        /// Style of the box representing the item's base size
        /// </summary>
        public CefNet.DevTools.Protocol.Overlay.BoxStyle? BaseSizeBox { get; set; }

        /// <summary>
        /// Style of the border around the box representing the item's base size
        /// </summary>
        public CefNet.DevTools.Protocol.Overlay.LineStyle? BaseSizeBorder { get; set; }

        /// <summary>
        /// Style of the arrow representing if the item grew or shrank
        /// </summary>
        public CefNet.DevTools.Protocol.Overlay.LineStyle? FlexibilityArrow { get; set; }
    }
}
