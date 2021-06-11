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
    /// [Experimental] Determines what type of Trust Token operation is executed and
    /// depending on the type, some additional parameters. The values
    /// are specified in third_party/blink/renderer/core/fetch/trust_token.idl.
    /// </summary>
    public sealed class TrustTokenParams
    {
        public CefNet.DevTools.Protocol.Network.TrustTokenOperationType Type { get; set; }

        /// <summary>
        /// Only set for "token-redemption" type and determine whether
        /// to request a fresh SRR or use a still valid cached SRR.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.TrustTokenParamsRefreshPolicy RefreshPolicy { get; set; }

        /// <summary>
        /// Origins of issuers from whom to request tokens or redemption
        /// records.
        /// </summary>
        public System.Collections.Generic.List<string>? Issuers { get; set; }
    }
}
