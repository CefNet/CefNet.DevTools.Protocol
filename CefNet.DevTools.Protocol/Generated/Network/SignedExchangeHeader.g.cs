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
    /// [Experimental] Information about a signed exchange header.
    /// https://wicg.github.io/webpackage/draft-yasskin-httpbis-origin-signed-exchanges-impl.html#cbor-representation
    /// </summary>
    public sealed class SignedExchangeHeader
    {
        /// <summary>Signed exchange request URL.</summary>
        public string RequestUrl { get; set; }

        /// <summary>Signed exchange response code.</summary>
        public int ResponseCode { get; set; }

        /// <summary>Signed exchange response headers.</summary>
        public CefNet.DevTools.Protocol.Network.Headers ResponseHeaders { get; set; }

        /// <summary>Signed exchange response signature.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Network.SignedExchangeSignature> Signatures { get; set; }

        /// <summary>
        /// Signed exchange header integrity hash in the form of "sha256-<base64-hash-value>".
        /// </summary>
        public string HeaderIntegrity { get; set; }
    }
}
