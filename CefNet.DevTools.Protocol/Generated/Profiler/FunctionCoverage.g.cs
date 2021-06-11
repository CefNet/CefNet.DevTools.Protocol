//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Profiler
{
    /// <summary>Coverage data for a JavaScript function.</summary>
    public sealed class FunctionCoverage
    {
        /// <summary>JavaScript function name.</summary>
        public string FunctionName { get; set; }

        /// <summary>
        /// Source ranges inside the function with coverage data.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Profiler.CoverageRange> Ranges { get; set; }

        /// <summary>
        /// Whether coverage data for this function has block granularity.
        /// </summary>
        public bool IsBlockCoverage { get; set; }
    }
}
