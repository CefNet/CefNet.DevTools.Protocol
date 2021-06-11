//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Fetch
{
    public sealed class FulfillRequestRequest
    {
        /// <summary>
        /// An id the client received in requestPaused event.
        /// </summary>
        public CefNet.DevTools.Protocol.Fetch.RequestId RequestId { get; set; }

        /// <summary>An HTTP response code.</summary>
        public int ResponseCode { get; set; }

        /// <summary>Response headers.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Fetch.HeaderEntry>? ResponseHeaders { get; set; }

        /// <summary>
        /// Alternative way of specifying response headers as a \0-separated
        /// series of name: value pairs. Prefer the above method unless you
        /// need to represent some non-UTF8 values that can't be transmitted
        /// over the protocol as text.
        /// </summary>
        public byte[]? BinaryResponseHeaders { get; set; }

        /// <summary>A response body.</summary>
        public byte[]? Body { get; set; }

        /// <summary>
        /// A textual representation of responseCode.
        /// If absent, a standard phrase matching responseCode is used.
        /// </summary>
        public string? ResponsePhrase { get; set; }
    }
}
