//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Network
{
    public sealed class RequestWillBeSentExtraInfoEventArgs
        : System.EventArgs
    {
        /// <summary>
        /// Request identifier. Used to match this information to an existing requestWillBeSent event.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.RequestId RequestId { get; set; }

        /// <summary>
        /// A list of cookies potentially associated to the requested URL. This includes both cookies sent with
        /// the request and the ones not sent; the latter are distinguished by having blockedReason field set.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Network.BlockedCookieWithReason> AssociatedCookies { get; set; }

        /// <summary>
        /// Raw request headers as they will be sent over the wire.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.Headers Headers { get; set; }

        /// <summary>
        /// The client security state set for the request.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.ClientSecurityState? ClientSecurityState { get; set; }
    }
}
