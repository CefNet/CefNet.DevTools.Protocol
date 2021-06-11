//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Network
{
    public sealed class ResponseReceivedExtraInfoEventArgs
        : System.EventArgs
    {
        /// <summary>
        /// Request identifier. Used to match this information to another responseReceived event.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.RequestId RequestId { get; set; }

        /// <summary>
        /// A list of cookies which were not stored from the response along with the corresponding
        /// reasons for blocking. The cookies here may not be valid due to syntax errors, which
        /// are represented by the invalid cookie line string instead of a proper cookie.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Network.BlockedSetCookieWithReason> BlockedCookies { get; set; }

        /// <summary>
        /// Raw response headers as they were received over the wire.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.Headers Headers { get; set; }

        /// <summary>
        /// The IP address space of the resource. The address space can only be determined once the transport
        /// established the connection, so we can't send it in `requestWillBeSentExtraInfo`.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.IPAddressSpace ResourceIPAddressSpace { get; set; }

        /// <summary>
        /// Raw response header text as it was received over the wire. The raw text may not always be
        /// available, such as in the case of HTTP/2 or QUIC.
        /// </summary>
        public string? HeadersText { get; set; }
    }
}
