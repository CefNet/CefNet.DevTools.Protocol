//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Network
{
    public sealed class EventSourceMessageReceivedEventArgs
        : System.EventArgs
    {
        /// <summary>Request identifier.</summary>
        public CefNet.DevTools.Protocol.Network.RequestId RequestId { get; set; }

        /// <summary>Timestamp.</summary>
        public CefNet.DevTools.Protocol.Network.MonotonicTime Timestamp { get; set; }

        /// <summary>Message type.</summary>
        public string EventName { get; set; }

        /// <summary>Message identifier.</summary>
        public string EventId { get; set; }

        /// <summary>Message content.</summary>
        public string Data { get; set; }
    }
}
