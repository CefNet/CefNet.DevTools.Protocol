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
    /// Details of an element in the DOM tree with a LayoutObject.
    /// </summary>
    public sealed class LayoutTreeNode
    {
        /// <summary>
        /// The index of the related DOM node in the `domNodes` array returned by `getSnapshot`.
        /// </summary>
        public int DomNodeIndex { get; set; }

        /// <summary>
        /// The bounding box in document coordinates. Note that scroll offset of the document is ignored.
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.Rect BoundingBox { get; set; }

        /// <summary>Contents of the LayoutText, if any.</summary>
        public string? LayoutText { get; set; }

        /// <summary>
        /// The post-layout inline text nodes, if any.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.DOMSnapshot.InlineTextBox>? InlineTextNodes { get; set; }

        /// <summary>
        /// Index into the `computedStyles` array returned by `getSnapshot`.
        /// </summary>
        public int? StyleIndex { get; set; }

        /// <summary>
        /// Global paint order index, which is determined by the stacking order of the nodes. Nodes
        /// that are painted together will have the same index. Only provided if includePaintOrder in
        /// getSnapshot was true.
        /// </summary>
        public int? PaintOrder { get; set; }

        /// <summary>
        /// Set to true to indicate the element begins a new stacking context.
        /// </summary>
        public bool? IsStackingContext { get; set; }
    }
}
