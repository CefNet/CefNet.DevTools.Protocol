//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.HeapProfiler
{
    public sealed class HeapStatsUpdateEventArgs
        : System.EventArgs
    {
        /// <summary>
        /// An array of triplets. Each triplet describes a fragment. The first integer is the fragment
        /// index, the second integer is a total count of objects for the fragment, the third integer is
        /// a total size of the objects for the fragment.
        /// </summary>
        public System.Collections.Generic.List<int> StatsUpdate { get; set; }
    }
}
