//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Network
{
    public sealed class LoadingFinishedEventArgs
        : System.EventArgs
    {
        /// <summary>Request identifier.</summary>
        public CefNet.DevTools.Protocol.Network.RequestId RequestId { get; set; }

        /// <summary>Timestamp.</summary>
        public CefNet.DevTools.Protocol.Network.MonotonicTime Timestamp { get; set; }

        /// <summary>
        /// Total number of bytes received for this request.
        /// </summary>
        public double EncodedDataLength { get; set; }

        /// <summary>
        /// Set when 1) response was blocked by Cross-Origin Read Blocking and also
        /// 2) this needs to be reported to the DevTools console.
        /// </summary>
        public bool? ShouldReportCorbBlocking { get; set; }
    }
}
