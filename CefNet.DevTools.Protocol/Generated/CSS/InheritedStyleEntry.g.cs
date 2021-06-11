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
    /// Inherited CSS rule collection from ancestor node.
    /// </summary>
    public sealed class InheritedStyleEntry
    {
        /// <summary>
        /// The ancestor node's inline style, if any, in the style inheritance chain.
        /// </summary>
        public CefNet.DevTools.Protocol.CSS.CSSStyle? InlineStyle { get; set; }

        /// <summary>
        /// Matches of CSS rules matching the ancestor node in the style inheritance chain.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.CSS.RuleMatch> MatchedCSSRules { get; set; }
    }
}
