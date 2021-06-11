//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.CSS
{
    public sealed class GetMatchedStylesForNodeResponse
    {
        /// <summary>Inline style for the specified DOM node.</summary>
        public CefNet.DevTools.Protocol.CSS.CSSStyle? InlineStyle { get; set; }

        /// <summary>
        /// Attribute-defined element style (e.g. resulting from "width=20 height=100%").
        /// </summary>
        public CefNet.DevTools.Protocol.CSS.CSSStyle? AttributesStyle { get; set; }

        /// <summary>
        /// CSS rules matching this node, from all applicable stylesheets.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.CSS.RuleMatch>? MatchedCSSRules { get; set; }

        /// <summary>Pseudo style matches for this node.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.CSS.PseudoElementMatches>? PseudoElements { get; set; }

        /// <summary>
        /// A chain of inherited styles (from the immediate node parent up to the DOM tree root).
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.CSS.InheritedStyleEntry>? Inherited { get; set; }

        /// <summary>
        /// A list of CSS keyframed animations matching this node.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.CSS.CSSKeyframesRule>? CssKeyframesRules { get; set; }
    }
}
