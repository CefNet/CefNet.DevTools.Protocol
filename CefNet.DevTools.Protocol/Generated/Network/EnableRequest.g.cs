//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Network
{
    public sealed class EnableRequest
    {
        /// <summary>
        /// [Experimental] Buffer size in bytes to use when preserving network payloads (XHRs, etc).
        /// </summary>
        public int? MaxTotalBufferSize { get; set; }

        /// <summary>
        /// [Experimental] Per-resource buffer size in bytes to use when preserving network payloads (XHRs, etc).
        /// </summary>
        public int? MaxResourceBufferSize { get; set; }

        /// <summary>
        /// Longest post body size (in bytes) that would be included in requestWillBeSent notification
        /// </summary>
        public int? MaxPostDataSize { get; set; }
    }
}
