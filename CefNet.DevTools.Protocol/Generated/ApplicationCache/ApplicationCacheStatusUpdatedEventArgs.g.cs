//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.ApplicationCache
{
    public sealed class ApplicationCacheStatusUpdatedEventArgs
        : System.EventArgs
    {
        /// <summary>
        /// Identifier of the frame containing document whose application cache updated status.
        /// </summary>
        public CefNet.DevTools.Protocol.Page.FrameId FrameId { get; set; }

        /// <summary>Manifest URL.</summary>
        public string ManifestURL { get; set; }

        /// <summary>Updated application cache status.</summary>
        public int Status { get; set; }
    }
}
