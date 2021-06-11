//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.CSS
{
    /// <summary>
    /// Text range within a resource. All numbers are zero-based.
    /// </summary>
    public sealed class SourceRange
    {
        /// <summary>Start line of range.</summary>
        public int StartLine { get; set; }

        /// <summary>Start column of range (inclusive).</summary>
        public int StartColumn { get; set; }

        /// <summary>End line of range</summary>
        public int EndLine { get; set; }

        /// <summary>End column of range (exclusive).</summary>
        public int EndColumn { get; set; }
    }
}
