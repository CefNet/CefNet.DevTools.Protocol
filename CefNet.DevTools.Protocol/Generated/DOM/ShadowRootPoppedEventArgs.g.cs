//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOM
{
    public sealed class ShadowRootPoppedEventArgs
        : System.EventArgs
    {
        /// <summary>Host element id.</summary>
        public CefNet.DevTools.Protocol.DOM.NodeId HostId { get; set; }

        /// <summary>Shadow root id.</summary>
        public CefNet.DevTools.Protocol.DOM.NodeId RootId { get; set; }
    }
}
