//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    /// <summary>
    /// [Experimental] Per-script compilation cache parameters for `Page.produceCompilationCache`
    /// </summary>
    public sealed class CompilationCacheParams
    {
        /// <summary>
        /// The URL of the script to produce a compilation cache entry for.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// A hint to the backend whether eager compilation is recommended.
        /// (the actual compilation mode used is upon backend discretion).
        /// </summary>
        public bool? Eager { get; set; }
    }
}
