//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOM
{
    public sealed class ScrollIntoViewIfNeededRequest
    {
        /// <summary>Identifier of the node.</summary>
        public CefNet.DevTools.Protocol.DOM.NodeId? NodeId { get; set; }

        /// <summary>Identifier of the backend node.</summary>
        public CefNet.DevTools.Protocol.DOM.BackendNodeId? BackendNodeId { get; set; }

        /// <summary>
        /// JavaScript object id of the node wrapper.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.RemoteObjectId? ObjectId { get; set; }

        /// <summary>
        /// The rect to be scrolled into view, relative to the node's border box, in CSS pixels.
        /// When omitted, center of the node will be used, similar to Element.scrollIntoView.
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.Rect? Rect { get; set; }
    }
}
