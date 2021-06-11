//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Debugger
{
    public sealed class BreakLocation
    {
        /// <summary>
        /// Script identifier as reported in the `Debugger.scriptParsed`.
        /// </summary>
        public CefNet.DevTools.Protocol.Runtime.ScriptId ScriptId { get; set; }

        /// <summary>Line number in the script (0-based).</summary>
        public int LineNumber { get; set; }

        /// <summary>Column number in the script (0-based).</summary>
        public int? ColumnNumber { get; set; }

        public CefNet.DevTools.Protocol.Debugger.BreakLocationType? Type { get; set; }
    }
}
