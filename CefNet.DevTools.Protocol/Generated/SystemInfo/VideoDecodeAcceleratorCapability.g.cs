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
    /// Describes a supported video decoding profile with its associated minimum and
    /// maximum resolutions.
    /// </summary>
    public sealed class VideoDecodeAcceleratorCapability
    {
        /// <summary>
        /// Video codec profile that is supported, e.g. VP9 Profile 2.
        /// </summary>
        public string Profile { get; set; }

        /// <summary>
        /// Maximum video dimensions in pixels supported for this |profile|.
        /// </summary>
        public CefNet.DevTools.Protocol.SystemInfo.Size MaxResolution { get; set; }

        /// <summary>
        /// Minimum video dimensions in pixels supported for this |profile|.
        /// </summary>
        public CefNet.DevTools.Protocol.SystemInfo.Size MinResolution { get; set; }
    }
}
