//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOM
{
    public sealed class MoveToRequest
    {
        /// <summary>Id of the node to move.</summary>
        public CefNet.DevTools.Protocol.DOM.NodeId NodeId { get; set; }

        /// <summary>
        /// Id of the element to drop the moved node into.
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.NodeId TargetNodeId { get; set; }

        /// <summary>
        /// Drop node before this one (if absent, the moved node becomes the last child of
        /// `targetNodeId`).
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.NodeId? InsertBeforeNodeId { get; set; }
    }
}
