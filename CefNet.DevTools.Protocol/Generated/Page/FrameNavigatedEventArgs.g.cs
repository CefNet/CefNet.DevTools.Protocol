//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    public sealed class FrameNavigatedEventArgs
        : System.EventArgs
    {
        /// <summary>Frame object.</summary>
        public CefNet.DevTools.Protocol.Page.Frame Frame { get; set; }

        /// <summary>[Experimental] </summary>
        public CefNet.DevTools.Protocol.Page.NavigationType Type { get; set; }
    }
}
