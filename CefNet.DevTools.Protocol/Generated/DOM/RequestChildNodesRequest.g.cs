//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOM
{
    public sealed class RequestChildNodesRequest
    {
        /// <summary>Id of the node to get children for.</summary>
        public CefNet.DevTools.Protocol.DOM.NodeId NodeId { get; set; }

        /// <summary>
        /// The maximum depth at which children should be retrieved, defaults to 1. Use -1 for the
        /// entire subtree or provide an integer larger than 0.
        /// </summary>
        public int? Depth { get; set; }

        /// <summary>
        /// Whether or not iframes and shadow roots should be traversed when returning the sub-tree
        /// (default is false).
        /// </summary>
        public bool? Pierce { get; set; }
    }
}
