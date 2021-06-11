//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOMSnapshot
{
    public sealed class GetSnapshotRequest
    {
        /// <summary>Whitelist of computed styles to return.</summary>
        public System.Collections.Generic.List<string> ComputedStyleWhitelist { get; set; }

        /// <summary>
        /// Whether or not to retrieve details of DOM listeners (default false).
        /// </summary>
        public bool? IncludeEventListeners { get; set; }

        /// <summary>
        /// Whether to determine and include the paint order index of LayoutTreeNodes (default false).
        /// </summary>
        public bool? IncludePaintOrder { get; set; }

        /// <summary>
        /// Whether to include UA shadow tree in the snapshot (default false).
        /// </summary>
        public bool? IncludeUserAgentShadowTree { get; set; }
    }
}
