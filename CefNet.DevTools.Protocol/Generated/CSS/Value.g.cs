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
    /// Data for a simple selector (these are delimited by commas in a selector list).
    /// </summary>
    public sealed class Value
    {
        /// <summary>Value text.</summary>
        public string Text { get; set; }

        /// <summary>
        /// Value range in the underlying resource (if available).
        /// </summary>
        public CefNet.DevTools.Protocol.CSS.SourceRange? Range { get; set; }
    }
}
