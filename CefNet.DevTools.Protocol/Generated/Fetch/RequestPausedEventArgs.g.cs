//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Fetch
{
    public sealed class RequestPausedEventArgs
        : System.EventArgs
    {
        /// <summary>
        /// Each request the page makes will have a unique id.
        /// </summary>
        public CefNet.DevTools.Protocol.Fetch.RequestId RequestId { get; set; }

        /// <summary>The details of the request.</summary>
        public CefNet.DevTools.Protocol.Network.Request Request { get; set; }

        /// <summary>
        /// The id of the frame that initiated the request.
        /// </summary>
        public CefNet.DevTools.Protocol.Page.FrameId FrameId { get; set; }

        /// <summary>How the requested resource will be used.</summary>
        public CefNet.DevTools.Protocol.Network.ResourceType ResourceType { get; set; }

        /// <summary>
        /// Response error if intercepted at response stage.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.ErrorReason? ResponseErrorReason { get; set; }

        /// <summary>
        /// Response code if intercepted at response stage.
        /// </summary>
        public int? ResponseStatusCode { get; set; }

        /// <summary>
        /// Response headers if intercepted at the response stage.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Fetch.HeaderEntry>? ResponseHeaders { get; set; }

        /// <summary>
        /// If the intercepted request had a corresponding Network.requestWillBeSent event fired for it,
        /// then this networkId will be the same as the requestId present in the requestWillBeSent event.
        /// </summary>
        public CefNet.DevTools.Protocol.Fetch.RequestId? NetworkId { get; set; }
    }
}
