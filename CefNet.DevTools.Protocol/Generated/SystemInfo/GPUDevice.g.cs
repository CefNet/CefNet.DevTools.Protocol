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
    /// Describes a single graphics processor (GPU).
    /// </summary>
    public sealed class GPUDevice
    {
        /// <summary>
        /// PCI ID of the GPU vendor, if available; 0 otherwise.
        /// </summary>
        public double VendorId { get; set; }

        /// <summary>
        /// PCI ID of the GPU device, if available; 0 otherwise.
        /// </summary>
        public double DeviceId { get; set; }

        /// <summary>
        /// Sub sys ID of the GPU, only available on Windows.
        /// </summary>
        public double? SubSysId { get; set; }

        /// <summary>
        /// Revision of the GPU, only available on Windows.
        /// </summary>
        public double? Revision { get; set; }

        /// <summary>
        /// String description of the GPU vendor, if the PCI ID is not available.
        /// </summary>
        public string VendorString { get; set; }

        /// <summary>
        /// String description of the GPU device, if the PCI ID is not available.
        /// </summary>
        public string DeviceString { get; set; }

        /// <summary>
        /// String description of the GPU driver vendor.
        /// </summary>
        public string DriverVendor { get; set; }

        /// <summary>
        /// String description of the GPU driver version.
        /// </summary>
        public string DriverVersion { get; set; }
    }
}
