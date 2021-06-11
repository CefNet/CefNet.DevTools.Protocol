//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Browser
{
    /// <summary>
    /// [Experimental] Browser window bounds information
    /// </summary>
    public sealed class Bounds
    {
        /// <summary>
        /// The offset from the left edge of the screen to the window in pixels.
        /// </summary>
        public int? Left { get; set; }

        /// <summary>
        /// The offset from the top edge of the screen to the window in pixels.
        /// </summary>
        public int? Top { get; set; }

        /// <summary>The window width in pixels.</summary>
        public int? Width { get; set; }

        /// <summary>The window height in pixels.</summary>
        public int? Height { get; set; }

        /// <summary>The window state. Default to normal.</summary>
        public CefNet.DevTools.Protocol.Browser.WindowState? WindowState { get; set; }
    }
}
