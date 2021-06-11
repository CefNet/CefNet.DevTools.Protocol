//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOM
{
    public sealed class ResolveNodeRequest
    {
        /// <summary>Id of the node to resolve.</summary>
        public CefNet.DevTools.Protocol.DOM.NodeId? NodeId { get; set; }

        /// <summary>
        /// Backend identifier of the node to resolve.
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.BackendNodeId? BackendNodeId { get; set; }

        /// <summary>
        /// Symbolic group name that can be used to release multiple objects.
        /// </summary>
        public string? ObjectGroup { get; set; }

        /// <summary>
        /// Execution context in which to resolve the node.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.ExecutionContextId? ExecutionContextId { get; set; }
    }
}
