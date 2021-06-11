//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Network
{
    public sealed class EmulateNetworkConditionsRequest
    {
        /// <summary>True to emulate internet disconnection.</summary>
        public bool Offline { get; set; }

        /// <summary>
        /// Minimum latency from request sent to response headers received (ms).
        /// </summary>
        public double Latency { get; set; }

        /// <summary>
        /// Maximal aggregated download throughput (bytes/sec). -1 disables download throttling.
        /// </summary>
        public double DownloadThroughput { get; set; }

        /// <summary>
        /// Maximal aggregated upload throughput (bytes/sec).  -1 disables upload throttling.
        /// </summary>
        public double UploadThroughput { get; set; }

        /// <summary>Connection type if known.</summary>
        public CefNet.DevTools.Protocol.Network.ConnectionType? ConnectionType { get; set; }
    }
}
