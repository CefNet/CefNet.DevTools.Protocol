//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.SystemInfo
{
    public sealed class GetInfoResponse
    {
        /// <summary>
        /// Information about the GPUs on the system.
        /// </summary>
        public CefNet.DevTools.Protocol.SystemInfo.GPUInfo Gpu { get; set; }

        /// <summary>
        /// A platform-dependent description of the model of the machine. On Mac OS, this is, for
        /// example, 'MacBookPro'. Will be the empty string if not supported.
        /// </summary>
        public string ModelName { get; set; }

        /// <summary>
        /// A platform-dependent description of the version of the machine. On Mac OS, this is, for
        /// example, '10.1'. Will be the empty string if not supported.
        /// </summary>
        public string ModelVersion { get; set; }

        /// <summary>
        /// The command line string used to launch the browser. Will be the empty string if not
        /// supported.
        /// </summary>
        public string CommandLine { get; set; }
    }
}
