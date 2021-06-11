//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    /// <summary>
    /// [Experimental] Information about the Resource on the page.
    /// </summary>
    public sealed class FrameResource
    {
        /// <summary>Resource URL.</summary>
        public string Url { get; set; }

        /// <summary>Type of this resource.</summary>
        public CefNet.DevTools.Protocol.Network.ResourceType Type { get; set; }

        /// <summary>
        /// Resource mimeType as determined by the browser.
        /// </summary>
        public string MimeType { get; set; }

        /// <summary>
        /// last-modified timestamp as reported by server.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.TimeSinceEpoch? LastModified { get; set; }

        /// <summary>Resource content size.</summary>
        public double? ContentSize { get; set; }

        /// <summary>True if the resource failed to load.</summary>
        public bool? Failed { get; set; }

        /// <summary>
        /// True if the resource was canceled during loading.
        /// </summary>
        public bool? Canceled { get; set; }
    }
}
