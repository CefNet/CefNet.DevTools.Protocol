//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.SystemInfo
{
    /// <summary>
    /// Describes a supported video encoding profile with its associated maximum
    /// resolution and maximum framerate.
    /// </summary>
    public sealed class VideoEncodeAcceleratorCapability
    {
        /// <summary>
        /// Video codec profile that is supported, e.g H264 Main.
        /// </summary>
        public string Profile { get; set; }

        /// <summary>
        /// Maximum video dimensions in pixels supported for this |profile|.
        /// </summary>
        public CefNet.DevTools.Protocol.SystemInfo.Size MaxResolution { get; set; }

        /// <summary>
        /// Maximum encoding framerate in frames per second supported for this
        /// |profile|, as fraction's numerator and denominator, e.g. 24/1 fps,
        /// 24000/1001 fps, etc.
        /// </summary>
        public int MaxFramerateNumerator { get; set; }

        public int MaxFramerateDenominator { get; set; }
    }
}
