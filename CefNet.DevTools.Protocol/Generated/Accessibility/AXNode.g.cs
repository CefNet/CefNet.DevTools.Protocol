//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Accessibility
{
    /// <summary>A node in the accessibility tree.</summary>
    public sealed class AXNode
    {
        /// <summary>Unique identifier for this node.</summary>
        public CefNet.DevTools.Protocol.Accessibility.AXNodeId NodeId { get; set; }

        /// <summary>
        /// Whether this node is ignored for accessibility
        /// </summary>
        public bool Ignored { get; set; }

        /// <summary>
        /// Collection of reasons why this node is hidden.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Accessibility.AXProperty>? IgnoredReasons { get; set; }

        /// <summary>
        /// This `Node`'s role, whether explicit or implicit.
        /// </summary>
        public CefNet.DevTools.Protocol.Accessibility.AXValue? Role { get; set; }

        /// <summary>The accessible name for this `Node`.</summary>
        public CefNet.DevTools.Protocol.Accessibility.AXValue? Name { get; set; }

        /// <summary>
        /// The accessible description for this `Node`.
        /// </summary>
        public CefNet.DevTools.Protocol.Accessibility.AXValue? Description { get; set; }

        /// <summary>The value for this `Node`.</summary>
        public CefNet.DevTools.Protocol.Accessibility.AXValue? Value { get; set; }

        /// <summary>All other properties</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Accessibility.AXProperty>? Properties { get; set; }

        /// <summary>IDs for each of this node's child nodes.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Accessibility.AXNodeId>? ChildIds { get; set; }

        /// <summary>
        /// The backend ID for the associated DOM node, if any.
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.BackendNodeId? BackendDOMNodeId { get; set; }
    }
}
