//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.CSS
{
    /// <summary>CSS property declaration data.</summary>
    public sealed class CSSProperty
    {
        /// <summary>The property name.</summary>
        public string Name { get; set; }

        /// <summary>The property value.</summary>
        public string Value { get; set; }

        /// <summary>
        /// Whether the property has "!important" annotation (implies `false` if absent).
        /// </summary>
        public bool? Important { get; set; }

        /// <summary>
        /// Whether the property is implicit (implies `false` if absent).
        /// </summary>
        public bool? Implicit { get; set; }

        /// <summary>
        /// The full property text as specified in the style.
        /// </summary>
        public string? Text { get; set; }

        /// <summary>
        /// Whether the property is understood by the browser (implies `true` if absent).
        /// </summary>
        public bool? ParsedOk { get; set; }

        /// <summary>
        /// Whether the property is disabled by the user (present for source-based properties only).
        /// </summary>
        public bool? Disabled { get; set; }

        /// <summary>
        /// The entire property range in the enclosing style declaration (if available).
        /// </summary>
        public CefNet.DevTools.Protocol.CSS.SourceRange? Range { get; set; }
    }
}
