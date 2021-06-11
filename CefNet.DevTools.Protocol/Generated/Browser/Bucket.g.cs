//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Browser
{
    /// <summary>[Experimental] Chrome histogram bucket.</summary>
    public sealed class Bucket
    {
        /// <summary>Minimum value (inclusive).</summary>
        public int Low { get; set; }

        /// <summary>Maximum value (exclusive).</summary>
        public int High { get; set; }

        /// <summary>Number of samples.</summary>
        public int Count { get; set; }
    }
}
