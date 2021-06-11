//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    public sealed class LifecycleEventEventArgs
        : System.EventArgs
    {
        /// <summary>Id of the frame.</summary>
        public CefNet.DevTools.Protocol.Page.FrameId FrameId { get; set; }

        /// <summary>
        /// Loader identifier. Empty string if the request is fetched from worker.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.LoaderId LoaderId { get; set; }

        public string Name { get; set; }

        public CefNet.DevTools.Protocol.Network.MonotonicTime Timestamp { get; set; }
    }
}
