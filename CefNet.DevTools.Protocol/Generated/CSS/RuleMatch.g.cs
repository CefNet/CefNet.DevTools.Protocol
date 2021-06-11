//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.CSS
{
    /// <summary>Match data for a CSS rule.</summary>
    public sealed class RuleMatch
    {
        /// <summary>CSS rule in the match.</summary>
        public CefNet.DevTools.Protocol.CSS.CSSRule Rule { get; set; }

        /// <summary>
        /// Matching selector indices in the rule's selectorList selectors (0-based).
        /// </summary>
        public System.Collections.Generic.List<int> MatchingSelectors { get; set; }
    }
}
