//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Network
{
    public sealed class LoadingFailedEventArgs
        : System.EventArgs
    {
        /// <summary>Request identifier.</summary>
        public CefNet.DevTools.Protocol.Network.RequestId RequestId { get; set; }

        /// <summary>Timestamp.</summary>
        public CefNet.DevTools.Protocol.Network.MonotonicTime Timestamp { get; set; }

        /// <summary>Resource type.</summary>
        public CefNet.DevTools.Protocol.Network.ResourceType Type { get; set; }

        /// <summary>User friendly error message.</summary>
        public string ErrorText { get; set; }

        /// <summary>True if loading was canceled.</summary>
        public bool? Canceled { get; set; }

        /// <summary>
        /// The reason why loading was blocked, if any.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.BlockedReason? BlockedReason { get; set; }

        /// <summary>
        /// The reason why loading was blocked by CORS, if any.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.CorsErrorStatus? CorsErrorStatus { get; set; }
    }
}
