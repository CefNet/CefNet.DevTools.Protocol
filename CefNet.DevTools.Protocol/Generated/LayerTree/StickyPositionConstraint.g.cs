//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.LayerTree
{
    /// <summary>Sticky position constraints.</summary>
    public sealed class StickyPositionConstraint
    {
        /// <summary>
        /// Layout rectangle of the sticky element before being shifted
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.Rect StickyBoxRect { get; set; }

        /// <summary>
        /// Layout rectangle of the containing block of the sticky element
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.Rect ContainingBlockRect { get; set; }

        /// <summary>
        /// The nearest sticky layer that shifts the sticky box
        /// </summary>
        public CefNet.DevTools.Protocol.LayerTree.LayerId? NearestLayerShiftingStickyBox { get; set; }

        /// <summary>
        /// The nearest sticky layer that shifts the containing block
        /// </summary>
        public CefNet.DevTools.Protocol.LayerTree.LayerId? NearestLayerShiftingContainingBlock { get; set; }
    }
}
