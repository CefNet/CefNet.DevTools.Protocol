//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    public sealed class CaptureScreenshotRequest
    {
        /// <summary>
        /// Image compression format (defaults to png).
        /// </summary>
        public CefNet.DevTools.Protocol.Page.CaptureScreenshotRequestFormat? Format { get; set; }

        /// <summary>
        /// Compression quality from range [0..100] (jpeg only).
        /// </summary>
        public int? Quality { get; set; }

        /// <summary>
        /// Capture the screenshot of a given region only.
        /// </summary>
        public CefNet.DevTools.Protocol.Page.Viewport? Clip { get; set; }

        /// <summary>
        /// [Experimental] Capture the screenshot from the surface, rather than the view. Defaults to true.
        /// </summary>
        public bool? FromSurface { get; set; }

        /// <summary>
        /// [Experimental] Capture the screenshot beyond the viewport. Defaults to false.
        /// </summary>
        public bool? CaptureBeyondViewport { get; set; }
    }
}
