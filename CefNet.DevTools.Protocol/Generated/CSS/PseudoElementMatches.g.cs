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
    /// CSS rule collection for a single pseudo style.
    /// </summary>
    public sealed class PseudoElementMatches
    {
        /// <summary>Pseudo element type.</summary>
        public CefNet.DevTools.Protocol.DOM.PseudoType PseudoType { get; set; }

        /// <summary>
        /// Matches of CSS rules applicable to the pseudo style.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.CSS.RuleMatch> Matches { get; set; }
    }
}
