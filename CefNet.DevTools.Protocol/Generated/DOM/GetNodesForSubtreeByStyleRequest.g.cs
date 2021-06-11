//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOM
{
    public sealed class GetNodesForSubtreeByStyleRequest
    {
        /// <summary>
        /// Node ID pointing to the root of a subtree.
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.NodeId NodeId { get; set; }

        /// <summary>
        /// The style to filter nodes by (includes nodes if any of properties matches).
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.DOM.CSSComputedStyleProperty> ComputedStyles { get; set; }

        /// <summary>
        /// Whether or not iframes and shadow roots in the same target should be traversed when returning the
        /// results (default is false).
        /// </summary>
        public bool? Pierce { get; set; }
    }
}
