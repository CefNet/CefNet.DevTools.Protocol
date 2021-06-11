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
    /// Provides information about the GPU(s) on the system.
    /// </summary>
    public sealed class GPUInfo
    {
        /// <summary>
        /// The graphics devices on the system. Element 0 is the primary GPU.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.SystemInfo.GPUDevice> Devices { get; set; }

        /// <summary>
        /// An optional dictionary of additional GPU related attributes.
        /// </summary>
        public System.Collections.Generic.Dictionary<string, object>? AuxAttributes { get; set; }

        /// <summary>
        /// An optional dictionary of graphics features and their status.
        /// </summary>
        public System.Collections.Generic.Dictionary<string, object>? FeatureStatus { get; set; }

        /// <summary>
        /// An optional array of GPU driver bug workarounds.
        /// </summary>
        public System.Collections.Generic.List<string> DriverBugWorkarounds { get; set; }

        /// <summary>
        /// Supported accelerated video decoding capabilities.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.SystemInfo.VideoDecodeAcceleratorCapability> VideoDecoding { get; set; }

        /// <summary>
        /// Supported accelerated video encoding capabilities.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.SystemInfo.VideoEncodeAcceleratorCapability> VideoEncoding { get; set; }

        /// <summary>
        /// Supported accelerated image decoding capabilities.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.SystemInfo.ImageDecodeAcceleratorCapability> ImageDecoding { get; set; }
    }
}
