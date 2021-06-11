//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Overlay
{
    /// <summary>
    /// Configurations for Persistent Grid Highlight
    /// </summary>
    public sealed class GridNodeHighlightConfig
    {
        /// <summary>
        /// A descriptor for the highlight appearance.
        /// </summary>
        public CefNet.DevTools.Protocol.Overlay.GridHighlightConfig GridHighlightConfig { get; set; }

        /// <summary>Identifier of the node to highlight.</summary>
        public CefNet.DevTools.Protocol.DOM.NodeId NodeId { get; set; }
    }
}
