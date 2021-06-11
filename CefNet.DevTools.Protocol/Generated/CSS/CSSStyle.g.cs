//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.CSS
{
    /// <summary>CSS style representation.</summary>
    public sealed class CSSStyle
    {
        /// <summary>
        /// The css style sheet identifier (absent for user agent stylesheet and user-specified
        /// stylesheet rules) this rule came from.
        /// </summary>
        public CefNet.DevTools.Protocol.CSS.StyleSheetId? StyleSheetId { get; set; }

        /// <summary>CSS properties in the style.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.CSS.CSSProperty> CssProperties { get; set; }

        /// <summary>
        /// Computed values for all shorthands found in the style.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.CSS.ShorthandEntry> ShorthandEntries { get; set; }

        /// <summary>Style declaration text (if available).</summary>
        public string? CssText { get; set; }

        /// <summary>
        /// Style declaration range in the enclosing stylesheet (if available).
        /// </summary>
        public CefNet.DevTools.Protocol.CSS.SourceRange? Range { get; set; }
    }
}
