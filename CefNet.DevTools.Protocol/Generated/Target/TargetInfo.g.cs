//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Target
{
    public sealed class TargetInfo
    {
        public CefNet.DevTools.Protocol.Target.TargetID TargetId { get; set; }

        public string Type { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }

        /// <summary>
        /// Whether the target has an attached client.
        /// </summary>
        public bool Attached { get; set; }

        /// <summary>Opener target Id</summary>
        public CefNet.DevTools.Protocol.Target.TargetID? OpenerId { get; set; }

        /// <summary>
        /// [Experimental] Whether the target has access to the originating window.
        /// </summary>
        public bool CanAccessOpener { get; set; }

        /// <summary>
        /// [Experimental] Frame id of originating window (is only set if target has an opener).
        /// </summary>
        public CefNet.DevTools.Protocol.Page.FrameId? OpenerFrameId { get; set; }

        /// <summary>[Experimental] </summary>
        public CefNet.DevTools.Protocol.Browser.BrowserContextID? BrowserContextId { get; set; }
    }
}
