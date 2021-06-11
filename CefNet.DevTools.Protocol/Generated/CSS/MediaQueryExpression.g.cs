//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.CSS
{
    /// <summary>Media query expression descriptor.</summary>
    public sealed class MediaQueryExpression
    {
        /// <summary>Media query expression value.</summary>
        public double Value { get; set; }

        /// <summary>Media query expression units.</summary>
        public string Unit { get; set; }

        /// <summary>Media query expression feature.</summary>
        public string Feature { get; set; }

        /// <summary>
        /// The associated range of the value text in the enclosing stylesheet (if available).
        /// </summary>
        public CefNet.DevTools.Protocol.CSS.SourceRange? ValueRange { get; set; }

        /// <summary>
        /// Computed length of media query expression (if applicable).
        /// </summary>
        public double? ComputedLength { get; set; }
    }
}
