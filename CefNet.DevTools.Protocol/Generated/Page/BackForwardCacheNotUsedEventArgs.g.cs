//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    public sealed class BackForwardCacheNotUsedEventArgs
        : System.EventArgs
    {
        /// <summary>
        /// The loader id for the associated navgation.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.LoaderId LoaderId { get; set; }

        /// <summary>The frame id of the associated frame.</summary>
        public CefNet.DevTools.Protocol.Page.FrameId FrameId { get; set; }
    }
}
