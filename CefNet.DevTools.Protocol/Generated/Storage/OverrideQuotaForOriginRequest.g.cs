//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Storage
{
    public sealed class OverrideQuotaForOriginRequest
    {
        /// <summary>Security origin.</summary>
        public string Origin { get; set; }

        /// <summary>
        /// The quota size (in bytes) to override the original quota with.
        /// If this is called multiple times, the overridden quota will be equal to
        /// the quotaSize provided in the final call. If this is called without
        /// specifying a quotaSize, the quota will be reset to the default value for
        /// the specified origin. If this is called multiple times with different
        /// origins, the override will be maintained for each origin until it is
        /// disabled (called without a quotaSize).
        /// </summary>
        public double? QuotaSize { get; set; }
    }
}
