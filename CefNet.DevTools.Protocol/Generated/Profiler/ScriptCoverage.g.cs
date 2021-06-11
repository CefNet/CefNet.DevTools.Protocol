//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Profiler
{
    /// <summary>Coverage data for a JavaScript script.</summary>
    public sealed class ScriptCoverage
    {
        /// <summary>JavaScript script id.</summary>
        public CefNet.DevTools.Protocol.Runtime.ScriptId ScriptId { get; set; }

        /// <summary>JavaScript script name or url.</summary>
        public string Url { get; set; }

        /// <summary>
        /// Functions contained in the script that has coverage data.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Profiler.FunctionCoverage> Functions { get; set; }
    }
}
