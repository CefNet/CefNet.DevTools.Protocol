//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOM
{
    public sealed class DistributedNodesUpdatedEventArgs
        : System.EventArgs
    {
        /// <summary>
        /// Insertion point where distributed nodes were updated.
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.NodeId InsertionPointId { get; set; }

        /// <summary>
        /// Distributed nodes for given insertion point.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.DOM.BackendNode> DistributedNodes { get; set; }
    }
}
