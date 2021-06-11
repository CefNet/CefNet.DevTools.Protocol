//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Network
{
    /// <summary>Information about the request initiator.</summary>
    public sealed class Initiator
    {
        /// <summary>Type of this initiator.</summary>
        public CefNet.DevTools.Protocol.Network.InitiatorType Type { get; set; }

        /// <summary>
        /// Initiator JavaScript stack trace, set for Script only.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.StackTrace? Stack { get; set; }

        /// <summary>
        /// Initiator URL, set for Parser type or for Script type (when script is importing module) or for SignedExchange type.
        /// </summary>
        public string? Url { get; set; }

        /// <summary>
        /// Initiator line number, set for Parser type or for Script type (when script is importing
        /// module) (0-based).
        /// </summary>
        public double? LineNumber { get; set; }

        /// <summary>
        /// Initiator column number, set for Parser type or for Script type (when script is importing
        /// module) (0-based).
        /// </summary>
        public double? ColumnNumber { get; set; }

        /// <summary>
        /// Set if another request triggered this request (e.g. preflight).
        /// </summary>
        public CefNet.DevTools.Protocol.Network.RequestId? RequestId { get; set; }
    }
}
