//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Overlay
{
    public sealed class HighlightSourceOrderRequest
    {
        /// <summary>
        /// A descriptor for the appearance of the overlay drawing.
        /// </summary>
        public CefNet.DevTools.Protocol.Overlay.SourceOrderConfig SourceOrderConfig { get; set; }

        /// <summary>Identifier of the node to highlight.</summary>
        public CefNet.DevTools.Protocol.DOM.NodeId? NodeId { get; set; }

        /// <summary>
        /// Identifier of the backend node to highlight.
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.BackendNodeId? BackendNodeId { get; set; }

        /// <summary>
        /// JavaScript object id of the node to be highlighted.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.RemoteObjectId? ObjectId { get; set; }
    }
}
