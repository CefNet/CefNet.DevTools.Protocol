//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Debugger
{
    public sealed class SetBreakpointByUrlRequest
    {
        /// <summary>Line number to set breakpoint at.</summary>
        public int LineNumber { get; set; }

        /// <summary>
        /// URL of the resources to set breakpoint on.
        /// </summary>
        public string? Url { get; set; }

        /// <summary>
        /// Regex pattern for the URLs of the resources to set breakpoints on. Either `url` or
        /// `urlRegex` must be specified.
        /// </summary>
        public string? UrlRegex { get; set; }

        /// <summary>
        /// Script hash of the resources to set breakpoint on.
        /// </summary>
        public string? ScriptHash { get; set; }

        /// <summary>Offset in the line to set breakpoint at.</summary>
        public int? ColumnNumber { get; set; }

        /// <summary>
        /// Expression to use as a breakpoint condition. When specified, debugger will only stop on the
        /// breakpoint if this expression evaluates to true.
        /// </summary>
        public string? Condition { get; set; }
    }
}
