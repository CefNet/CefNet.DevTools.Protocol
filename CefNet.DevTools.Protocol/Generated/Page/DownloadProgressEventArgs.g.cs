//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    public sealed class DownloadProgressEventArgs
        : System.EventArgs
    {
        /// <summary>
        /// Global unique identifier of the download.
        /// </summary>
        public string Guid { get; set; }

        /// <summary>Total expected bytes to download.</summary>
        public double TotalBytes { get; set; }

        /// <summary>Total bytes received.</summary>
        public double ReceivedBytes { get; set; }

        /// <summary>Download status.</summary>
        public CefNet.DevTools.Protocol.Page.DownloadProgressEventArgsState State { get; set; }
    }
}
