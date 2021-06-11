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
    /// [Experimental] An object providing the result of a network resource load.
    /// </summary>
    public sealed class LoadNetworkResourcePageResult
    {
        public bool Success { get; set; }

        /// <summary>
        /// Optional values used for error reporting.
        /// </summary>
        public double? NetError { get; set; }

        public string? NetErrorName { get; set; }

        public double? HttpStatusCode { get; set; }

        /// <summary>
        /// If successful, one of the following two fields holds the result.
        /// </summary>
        public CefNet.DevTools.Protocol.IO.StreamHandle? Stream { get; set; }

        /// <summary>Response headers.</summary>
        public CefNet.DevTools.Protocol.Network.Headers? Headers { get; set; }
    }
}
