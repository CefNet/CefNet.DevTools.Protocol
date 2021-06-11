//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Tracing
{
    public sealed class RequestMemoryDumpResponse
    {
        /// <summary>
        /// GUID of the resulting global memory dump.
        /// </summary>
        public string DumpGuid { get; set; }

        /// <summary>
        /// True iff the global memory dump succeeded.
        /// </summary>
        public bool Success { get; set; }
    }
}
