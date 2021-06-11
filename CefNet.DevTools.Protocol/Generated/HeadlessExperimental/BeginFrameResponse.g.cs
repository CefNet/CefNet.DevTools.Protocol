//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.HeadlessExperimental
{
    public sealed class BeginFrameResponse
    {
        /// <summary>
        /// Whether the BeginFrame resulted in damage and, thus, a new frame was committed to the
        /// display. Reported for diagnostic uses, may be removed in the future.
        /// </summary>
        public bool HasDamage { get; set; }

        /// <summary>
        /// Base64-encoded image data of the screenshot, if one was requested and successfully taken.
        /// </summary>
        public byte[]? ScreenshotData { get; set; }
    }
}
