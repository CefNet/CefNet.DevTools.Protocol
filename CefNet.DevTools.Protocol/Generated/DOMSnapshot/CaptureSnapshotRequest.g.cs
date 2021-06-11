//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOMSnapshot
{
    public sealed class CaptureSnapshotRequest
    {
        /// <summary>Whitelist of computed styles to return.</summary>
        public System.Collections.Generic.List<string> ComputedStyles { get; set; }

        /// <summary>
        /// Whether to include layout object paint orders into the snapshot.
        /// </summary>
        public bool? IncludePaintOrder { get; set; }

        /// <summary>
        /// Whether to include DOM rectangles (offsetRects, clientRects, scrollRects) into the snapshot
        /// </summary>
        public bool? IncludeDOMRects { get; set; }

        /// <summary>
        /// [Experimental] Whether to include blended background colors in the snapshot (default: false).
        /// Blended background color is achieved by blending background colors of all elements
        /// that overlap with the current element.
        /// </summary>
        public bool? IncludeBlendedBackgroundColors { get; set; }

        /// <summary>
        /// [Experimental] Whether to include text color opacity in the snapshot (default: false).
        /// An element might have the opacity property set that affects the text color of the element.
        /// The final text color opacity is computed based on the opacity of all overlapping elements.
        /// </summary>
        public bool? IncludeTextColorOpacities { get; set; }
    }
}
