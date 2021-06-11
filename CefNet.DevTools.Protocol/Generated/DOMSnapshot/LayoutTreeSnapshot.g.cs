//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOMSnapshot
{
    /// <summary>
    /// Table of details of an element in the DOM tree with a LayoutObject.
    /// </summary>
    public sealed class LayoutTreeSnapshot
    {
        /// <summary>
        /// Index of the corresponding node in the `NodeTreeSnapshot` array returned by `captureSnapshot`.
        /// </summary>
        public System.Collections.Generic.List<int> NodeIndex { get; set; }

        /// <summary>
        /// Array of indexes specifying computed style strings, filtered according to the `computedStyles` parameter passed to `captureSnapshot`.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.DOMSnapshot.ArrayOfStrings> Styles { get; set; }

        /// <summary>The absolute position bounding box.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.DOMSnapshot.Rectangle> Bounds { get; set; }

        /// <summary>Contents of the LayoutText, if any.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.DOMSnapshot.StringIndex> Text { get; set; }

        /// <summary>Stacking context information.</summary>
        public CefNet.DevTools.Protocol.DOMSnapshot.RareBooleanData StackingContexts { get; set; }

        /// <summary>
        /// Global paint order index, which is determined by the stacking order of the nodes. Nodes
        /// that are painted together will have the same index. Only provided if includePaintOrder in
        /// captureSnapshot was true.
        /// </summary>
        public System.Collections.Generic.List<int>? PaintOrders { get; set; }

        /// <summary>
        /// The offset rect of nodes. Only available when includeDOMRects is set to true
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.DOMSnapshot.Rectangle>? OffsetRects { get; set; }

        /// <summary>
        /// The scroll rect of nodes. Only available when includeDOMRects is set to true
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.DOMSnapshot.Rectangle>? ScrollRects { get; set; }

        /// <summary>
        /// The client rect of nodes. Only available when includeDOMRects is set to true
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.DOMSnapshot.Rectangle>? ClientRects { get; set; }

        /// <summary>
        /// [Experimental] The list of background colors that are blended with colors of overlapping elements.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.DOMSnapshot.StringIndex>? BlendedBackgroundColors { get; set; }

        /// <summary>
        /// [Experimental] The list of computed text opacities.
        /// </summary>
        public System.Collections.Generic.List<double>? TextColorOpacities { get; set; }
    }
}
