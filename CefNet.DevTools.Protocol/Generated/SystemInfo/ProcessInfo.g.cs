//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.SystemInfo
{
    /// <summary>Represents process info.</summary>
    public sealed class ProcessInfo
    {
        /// <summary>Specifies process type.</summary>
        public string Type { get; set; }

        /// <summary>Specifies process id.</summary>
        public int Id { get; set; }

        /// <summary>
        /// Specifies cumulative CPU usage in seconds across all threads of the
        /// process since the process start.
        /// </summary>
        public double CpuTime { get; set; }
    }
}
