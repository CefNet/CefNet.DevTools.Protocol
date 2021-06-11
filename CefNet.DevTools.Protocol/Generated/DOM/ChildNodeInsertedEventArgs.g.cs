//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOM
{
    public sealed class ChildNodeInsertedEventArgs
        : System.EventArgs
    {
        /// <summary>Id of the node that has changed.</summary>
        public CefNet.DevTools.Protocol.DOM.NodeId ParentNodeId { get; set; }

        /// <summary>If of the previous siblint.</summary>
        public CefNet.DevTools.Protocol.DOM.NodeId PreviousNodeId { get; set; }

        /// <summary>Inserted node data.</summary>
        public CefNet.DevTools.Protocol.DOM.Node Node { get; set; }
    }
}
