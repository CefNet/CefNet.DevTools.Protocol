//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOM
{
    public sealed class SetChildNodesEventArgs
        : System.EventArgs
    {
        /// <summary>
        /// Parent node id to populate with children.
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.NodeId ParentId { get; set; }

        /// <summary>Child nodes array.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.DOM.Node> Nodes { get; set; }
    }
}
