//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Network
{
    /// <summary>
    /// WebSocket message data. This represents an entire WebSocket message, not just a fragmented frame as the name suggests.
    /// </summary>
    public sealed class WebSocketFrame
    {
        /// <summary>WebSocket message opcode.</summary>
        public double Opcode { get; set; }

        /// <summary>WebSocket message mask.</summary>
        public bool Mask { get; set; }

        /// <summary>
        /// WebSocket message payload data.
        /// If the opcode is 1, this is a text message and payloadData is a UTF-8 string.
        /// If the opcode isn't 1, then payloadData is a base64 encoded string representing binary data.
        /// </summary>
        public string PayloadData { get; set; }
    }
}
