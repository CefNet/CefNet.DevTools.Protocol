//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Network
{
    /// <summary>WebSocket response data.</summary>
    public sealed class WebSocketResponse
    {
        /// <summary>HTTP response status code.</summary>
        public int Status { get; set; }

        /// <summary>HTTP response status text.</summary>
        public string StatusText { get; set; }

        /// <summary>HTTP response headers.</summary>
        public CefNet.DevTools.Protocol.Network.Headers Headers { get; set; }

        /// <summary>HTTP response headers text.</summary>
        public string? HeadersText { get; set; }

        /// <summary>HTTP request headers.</summary>
        public CefNet.DevTools.Protocol.Network.Headers? RequestHeaders { get; set; }

        /// <summary>HTTP request headers text.</summary>
        public string? RequestHeadersText { get; set; }
    }
}
