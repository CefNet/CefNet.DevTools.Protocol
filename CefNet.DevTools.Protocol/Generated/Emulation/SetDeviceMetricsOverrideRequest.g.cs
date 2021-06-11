//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Emulation
{
    public sealed class SetDeviceMetricsOverrideRequest
    {
        /// <summary>
        /// Overriding width value in pixels (minimum 0, maximum 10000000). 0 disables the override.
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Overriding height value in pixels (minimum 0, maximum 10000000). 0 disables the override.
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Overriding device scale factor value. 0 disables the override.
        /// </summary>
        public double DeviceScaleFactor { get; set; }

        /// <summary>
        /// Whether to emulate mobile device. This includes viewport meta tag, overlay scrollbars, text
        /// autosizing and more.
        /// </summary>
        public bool Mobile { get; set; }

        /// <summary>
        /// [Experimental] Scale to apply to resulting view image.
        /// </summary>
        public double? Scale { get; set; }

        /// <summary>
        /// [Experimental] Overriding screen width value in pixels (minimum 0, maximum 10000000).
        /// </summary>
        public int? ScreenWidth { get; set; }

        /// <summary>
        /// [Experimental] Overriding screen height value in pixels (minimum 0, maximum 10000000).
        /// </summary>
        public int? ScreenHeight { get; set; }

        /// <summary>
        /// [Experimental] Overriding view X position on screen in pixels (minimum 0, maximum 10000000).
        /// </summary>
        public int? PositionX { get; set; }

        /// <summary>
        /// [Experimental] Overriding view Y position on screen in pixels (minimum 0, maximum 10000000).
        /// </summary>
        public int? PositionY { get; set; }

        /// <summary>
        /// [Experimental] Do not set visible view size, rely upon explicit setVisibleSize call.
        /// </summary>
        public bool? DontSetVisibleSize { get; set; }

        /// <summary>Screen orientation override.</summary>
        public CefNet.DevTools.Protocol.Emulation.ScreenOrientation? ScreenOrientation { get; set; }

        /// <summary>
        /// [Experimental] If set, the visible area of the page will be overridden to this viewport. This viewport
        /// change is not observed by the page, e.g. viewport-relative elements do not change positions.
        /// </summary>
        public CefNet.DevTools.Protocol.Page.Viewport? Viewport { get; set; }

        /// <summary>
        /// [Experimental] If set, the display feature of a multi-segment screen. If not set, multi-segment support
        /// is turned-off.
        /// </summary>
        public CefNet.DevTools.Protocol.Emulation.DisplayFeature? DisplayFeature { get; set; }
    }
}
