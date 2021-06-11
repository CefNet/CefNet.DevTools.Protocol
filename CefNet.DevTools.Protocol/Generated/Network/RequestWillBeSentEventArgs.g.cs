//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Network
{
    public sealed class RequestWillBeSentEventArgs
        : System.EventArgs
    {
        /// <summary>Request identifier.</summary>
        public CefNet.DevTools.Protocol.Network.RequestId RequestId { get; set; }

        /// <summary>
        /// Loader identifier. Empty string if the request is fetched from worker.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.LoaderId LoaderId { get; set; }

        /// <summary>
        /// URL of the document this request is loaded for.
        /// </summary>
        public string DocumentURL { get; set; }

        /// <summary>Request data.</summary>
        public CefNet.DevTools.Protocol.Network.Request Request { get; set; }

        /// <summary>Timestamp.</summary>
        public CefNet.DevTools.Protocol.Network.MonotonicTime Timestamp { get; set; }

        /// <summary>Timestamp.</summary>
        public CefNet.DevTools.Protocol.Network.TimeSinceEpoch WallTime { get; set; }

        /// <summary>Request initiator.</summary>
        public CefNet.DevTools.Protocol.Network.Initiator Initiator { get; set; }

        /// <summary>Redirect response data.</summary>
        public CefNet.DevTools.Protocol.Network.Response? RedirectResponse { get; set; }

        /// <summary>Type of this resource.</summary>
        public CefNet.DevTools.Protocol.Network.ResourceType? Type { get; set; }

        /// <summary>Frame identifier.</summary>
        public CefNet.DevTools.Protocol.Page.FrameId? FrameId { get; set; }

        /// <summary>
        /// Whether the request is initiated by a user gesture. Defaults to false.
        /// </summary>
        public bool? HasUserGesture { get; set; }
    }
}
