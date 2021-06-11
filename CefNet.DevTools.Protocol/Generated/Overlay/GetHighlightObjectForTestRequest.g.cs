//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Overlay
{
    public sealed class GetHighlightObjectForTestRequest
    {
        /// <summary>
        /// Id of the node to get highlight object for.
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.NodeId NodeId { get; set; }

        /// <summary>Whether to include distance info.</summary>
        public bool? IncludeDistance { get; set; }

        /// <summary>Whether to include style info.</summary>
        public bool? IncludeStyle { get; set; }

        /// <summary>
        /// The color format to get config with (default: hex).
        /// </summary>
        public CefNet.DevTools.Protocol.Overlay.ColorFormat? ColorFormat { get; set; }

        /// <summary>
        /// Whether to show accessibility info (default: true).
        /// </summary>
        public bool? ShowAccessibilityInfo { get; set; }
    }
}
