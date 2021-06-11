//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Network
{
    public sealed class TrustTokenOperationDoneEventArgs
        : System.EventArgs
    {
        /// <summary>
        /// Detailed success or error status of the operation.
        /// 'AlreadyExists' also signifies a successful operation, as the result
        /// of the operation already exists und thus, the operation was abort
        /// preemptively (e.g. a cache hit).
        /// </summary>
        public CefNet.DevTools.Protocol.Network.TrustTokenOperationDoneEventArgsStatus Status { get; set; }

        public CefNet.DevTools.Protocol.Network.TrustTokenOperationType Type { get; set; }

        public CefNet.DevTools.Protocol.Network.RequestId RequestId { get; set; }

        /// <summary>
        /// Top level origin. The context in which the operation was attempted.
        /// </summary>
        public string? TopLevelOrigin { get; set; }

        /// <summary>
        /// Origin of the issuer in case of a "Issuance" or "Redemption" operation.
        /// </summary>
        public string? IssuerOrigin { get; set; }

        /// <summary>
        /// The number of obtained Trust Tokens on a successful "Issuance" operation.
        /// </summary>
        public int? IssuedTokenCount { get; set; }
    }
}
