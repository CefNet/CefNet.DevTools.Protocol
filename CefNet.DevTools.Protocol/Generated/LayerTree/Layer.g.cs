//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.LayerTree
{
    /// <summary>Information about a compositing layer.</summary>
    public sealed class Layer
    {
        /// <summary>The unique id for this layer.</summary>
        public CefNet.DevTools.Protocol.LayerTree.LayerId LayerId { get; set; }

        /// <summary>The id of parent (not present for root).</summary>
        public CefNet.DevTools.Protocol.LayerTree.LayerId? ParentLayerId { get; set; }

        /// <summary>
        /// The backend id for the node associated with this layer.
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.BackendNodeId? BackendNodeId { get; set; }

        /// <summary>Offset from parent layer, X coordinate.</summary>
        public double OffsetX { get; set; }

        /// <summary>Offset from parent layer, Y coordinate.</summary>
        public double OffsetY { get; set; }

        /// <summary>Layer width.</summary>
        public double Width { get; set; }

        /// <summary>Layer height.</summary>
        public double Height { get; set; }

        /// <summary>
        /// Transformation matrix for layer, default is identity matrix
        /// </summary>
        public System.Collections.Generic.List<double>? Transform { get; set; }

        /// <summary>
        /// Transform anchor point X, absent if no transform specified
        /// </summary>
        public double? AnchorX { get; set; }

        /// <summary>
        /// Transform anchor point Y, absent if no transform specified
        /// </summary>
        public double? AnchorY { get; set; }

        /// <summary>
        /// Transform anchor point Z, absent if no transform specified
        /// </summary>
        public double? AnchorZ { get; set; }

        /// <summary>
        /// Indicates how many time this layer has painted.
        /// </summary>
        public int PaintCount { get; set; }

        /// <summary>
        /// Indicates whether this layer hosts any content, rather than being used for
        /// transform/scrolling purposes only.
        /// </summary>
        public bool DrawsContent { get; set; }

        /// <summary>Set if layer is not visible.</summary>
        public bool? Invisible { get; set; }

        /// <summary>
        /// Rectangles scrolling on main thread only.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.LayerTree.ScrollRect>? ScrollRects { get; set; }

        /// <summary>Sticky position constraint information</summary>
        public CefNet.DevTools.Protocol.LayerTree.StickyPositionConstraint? StickyPositionConstraint { get; set; }
    }
}
