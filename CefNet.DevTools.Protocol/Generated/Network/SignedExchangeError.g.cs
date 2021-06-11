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
    public sealed class SignedExchangeError
    {
        /// <summary>Error message.</summary>
        public string Message { get; set; }

        /// <summary>
        /// The index of the signature which caused the error.
        /// </summary>
        public int? SignatureIndex { get; set; }

        /// <summary>The field which caused the error.</summary>
        public CefNet.DevTools.Protocol.Network.SignedExchangeErrorField? ErrorField { get; set; }
    }
}
