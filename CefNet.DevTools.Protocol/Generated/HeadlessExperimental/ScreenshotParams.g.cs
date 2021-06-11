//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.HeadlessExperimental
{
    /// <summary>Encoding options for a screenshot.</summary>
    public sealed class ScreenshotParams
    {
        /// <summary>
        /// Image compression format (defaults to png).
        /// </summary>
        public CefNet.DevTools.Protocol.HeadlessExperimental.ScreenshotParamsFormat? Format { get; set; }

        /// <summary>
        /// Compression quality from range [0..100] (jpeg only).
        /// </summary>
        public int? Quality { get; set; }
    }
}
