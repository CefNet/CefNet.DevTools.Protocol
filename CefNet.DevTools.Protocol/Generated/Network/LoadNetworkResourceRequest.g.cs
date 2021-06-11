//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Network
{
    public sealed class LoadNetworkResourceRequest
    {
        /// <summary>Frame id to get the resource for.</summary>
        public CefNet.DevTools.Protocol.Page.FrameId FrameId { get; set; }

        /// <summary>URL of the resource to get content for.</summary>
        public string Url { get; set; }

        /// <summary>Options for the request.</summary>
        public CefNet.DevTools.Protocol.Network.LoadNetworkResourceOptions Options { get; set; }
    }
}
