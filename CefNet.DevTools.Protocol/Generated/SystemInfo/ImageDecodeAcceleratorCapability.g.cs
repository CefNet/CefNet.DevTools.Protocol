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
    /// Describes a supported image decoding profile with its associated minimum and
    /// maximum resolutions and subsampling.
    /// </summary>
    public sealed class ImageDecodeAcceleratorCapability
    {
        /// <summary>Image coded, e.g. Jpeg.</summary>
        public CefNet.DevTools.Protocol.SystemInfo.ImageType ImageType { get; set; }

        /// <summary>
        /// Maximum supported dimensions of the image in pixels.
        /// </summary>
        public CefNet.DevTools.Protocol.SystemInfo.Size MaxDimensions { get; set; }

        /// <summary>
        /// Minimum supported dimensions of the image in pixels.
        /// </summary>
        public CefNet.DevTools.Protocol.SystemInfo.Size MinDimensions { get; set; }

        /// <summary>
        /// Optional array of supported subsampling formats, e.g. 4:2:0, if known.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.SystemInfo.SubsamplingFormat> Subsamplings { get; set; }
    }
}
