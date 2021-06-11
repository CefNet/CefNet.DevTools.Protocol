//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Browser
{
    /// <summary>[Experimental] Chrome histogram.</summary>
    public sealed class Histogram
    {
        /// <summary>Name.</summary>
        public string Name { get; set; }

        /// <summary>Sum of sample values.</summary>
        public int Sum { get; set; }

        /// <summary>Total number of samples.</summary>
        public int Count { get; set; }

        /// <summary>Buckets.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Browser.Bucket> Buckets { get; set; }
    }
}
