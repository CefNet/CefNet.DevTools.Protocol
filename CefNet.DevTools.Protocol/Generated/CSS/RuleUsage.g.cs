//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.CSS
{
    /// <summary>CSS coverage information.</summary>
    public sealed class RuleUsage
    {
        /// <summary>
        /// The css style sheet identifier (absent for user agent stylesheet and user-specified
        /// stylesheet rules) this rule came from.
        /// </summary>
        public CefNet.DevTools.Protocol.CSS.StyleSheetId StyleSheetId { get; set; }

        /// <summary>
        /// Offset of the start of the rule (including selector) from the beginning of the stylesheet.
        /// </summary>
        public double StartOffset { get; set; }

        /// <summary>
        /// Offset of the end of the rule body from the beginning of the stylesheet.
        /// </summary>
        public double EndOffset { get; set; }

        /// <summary>
        /// Indicates whether the rule was actually used by some element in the page.
        /// </summary>
        public bool Used { get; set; }
    }
}
