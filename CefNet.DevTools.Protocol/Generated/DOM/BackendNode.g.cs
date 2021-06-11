//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOM
{
    /// <summary>Backend node with a friendly name.</summary>
    public sealed class BackendNode
    {
        /// <summary>`Node`'s nodeType.</summary>
        public int NodeType { get; set; }

        /// <summary>`Node`'s nodeName.</summary>
        public string NodeName { get; set; }

        public CefNet.DevTools.Protocol.DOM.BackendNodeId BackendNodeId { get; set; }
    }
}
