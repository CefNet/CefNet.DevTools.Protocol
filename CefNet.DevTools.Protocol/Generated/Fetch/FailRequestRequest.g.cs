//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Fetch
{
    public sealed class FailRequestRequest
    {
        /// <summary>
        /// An id the client received in requestPaused event.
        /// </summary>
        public CefNet.DevTools.Protocol.Fetch.RequestId RequestId { get; set; }

        /// <summary>
        /// Causes the request to fail with the given reason.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.ErrorReason ErrorReason { get; set; }
    }
}
