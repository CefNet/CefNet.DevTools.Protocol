//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Fetch
{
    public sealed class ContinueRequestRequest
    {
        /// <summary>
        /// An id the client received in requestPaused event.
        /// </summary>
        public CefNet.DevTools.Protocol.Fetch.RequestId RequestId { get; set; }

        /// <summary>
        /// If set, the request url will be modified in a way that's not observable by page.
        /// </summary>
        public string? Url { get; set; }

        /// <summary>
        /// If set, the request method is overridden.
        /// </summary>
        public string? Method { get; set; }

        /// <summary>
        /// If set, overrides the post data in the request.
        /// </summary>
        public byte[]? PostData { get; set; }

        /// <summary>If set, overrides the request headers.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Fetch.HeaderEntry>? Headers { get; set; }
    }
}
