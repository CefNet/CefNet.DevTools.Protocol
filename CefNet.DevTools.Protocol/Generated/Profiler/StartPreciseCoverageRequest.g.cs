//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Profiler
{
    public sealed class StartPreciseCoverageRequest
    {
        /// <summary>
        /// Collect accurate call counts beyond simple 'covered' or 'not covered'.
        /// </summary>
        public bool? CallCount { get; set; }

        /// <summary>Collect block-based coverage.</summary>
        public bool? Detailed { get; set; }

        /// <summary>
        /// Allow the backend to send updates on its own initiative
        /// </summary>
        public bool? AllowTriggeredUpdates { get; set; }
    }
}
