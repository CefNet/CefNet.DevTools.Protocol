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
    /// [Experimental] Information about a signed exchange response.
    /// </summary>
    public sealed class SignedExchangeInfo
    {
        /// <summary>
        /// The outer response of signed HTTP exchange which was received from network.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.Response OuterResponse { get; set; }

        /// <summary>
        /// Information about the signed exchange header.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.SignedExchangeHeader? Header { get; set; }

        /// <summary>
        /// Security details for the signed exchange header.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.SecurityDetails? SecurityDetails { get; set; }

        /// <summary>
        /// Errors occurred while handling the signed exchagne.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Network.SignedExchangeError>? Errors { get; set; }
    }
}
