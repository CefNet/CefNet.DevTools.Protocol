//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.ApplicationCache
{
    /// <summary>Detailed application cache information.</summary>
    public sealed class ApplicationCache
    {
        /// <summary>Manifest URL.</summary>
        public string ManifestURL { get; set; }

        /// <summary>Application cache size.</summary>
        public double Size { get; set; }

        /// <summary>Application cache creation time.</summary>
        public double CreationTime { get; set; }

        /// <summary>Application cache update time.</summary>
        public double UpdateTime { get; set; }

        /// <summary>Application cache resources.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.ApplicationCache.ApplicationCacheResource> Resources { get; set; }
    }
}
