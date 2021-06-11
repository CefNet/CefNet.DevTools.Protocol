//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Runtime
{
    /// <summary>
    /// Stack entry for runtime errors and assertions.
    /// </summary>
    public sealed class CallFrame
    {
        /// <summary>JavaScript function name.</summary>
        public string FunctionName { get; set; }

        /// <summary>JavaScript script id.</summary>
        public CefNet.DevTools.Protocol.Runtime.ScriptId ScriptId { get; set; }

        /// <summary>JavaScript script name or url.</summary>
        public string Url { get; set; }

        /// <summary>JavaScript script line number (0-based).</summary>
        public int LineNumber { get; set; }

        /// <summary>
        /// JavaScript script column number (0-based).
        /// </summary>
        public int ColumnNumber { get; set; }
    }
}
