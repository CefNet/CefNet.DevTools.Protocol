//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Browser
{
    public sealed class SetWindowBoundsRequest
    {
        /// <summary>Browser window id.</summary>
        public CefNet.DevTools.Protocol.Browser.WindowID WindowId { get; set; }

        /// <summary>
        /// New window bounds. The 'minimized', 'maximized' and 'fullscreen' states cannot be combined
        /// with 'left', 'top', 'width' or 'height'. Leaves unspecified fields unchanged.
        /// </summary>
        public CefNet.DevTools.Protocol.Browser.Bounds Bounds { get; set; }
    }
}
