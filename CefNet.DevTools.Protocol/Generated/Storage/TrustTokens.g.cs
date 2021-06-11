//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Storage
{
    /// <summary>
    /// [Experimental] Pair of issuer origin and number of available (signed, but not used) Trust
    /// Tokens from that issuer.
    /// </summary>
    public sealed class TrustTokens
    {
        public string IssuerOrigin { get; set; }

        public double Count { get; set; }
    }
}
