//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Storage
{
    public sealed class GetUsageAndQuotaResponse
    {
        /// <summary>Storage usage (bytes).</summary>
        public double Usage { get; set; }

        /// <summary>Storage quota (bytes).</summary>
        public double Quota { get; set; }

        /// <summary>
        /// Whether or not the origin has an active storage quota override
        /// </summary>
        public bool OverrideActive { get; set; }

        /// <summary>Storage usage per type (bytes).</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Storage.UsageForType> UsageBreakdown { get; set; }
    }
}
