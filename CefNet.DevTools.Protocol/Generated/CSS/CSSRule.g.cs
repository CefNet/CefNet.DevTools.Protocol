//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.CSS
{
    /// <summary>CSS rule representation.</summary>
    public sealed class CSSRule
    {
        /// <summary>
        /// The css style sheet identifier (absent for user agent stylesheet and user-specified
        /// stylesheet rules) this rule came from.
        /// </summary>
        public CefNet.DevTools.Protocol.CSS.StyleSheetId? StyleSheetId { get; set; }

        /// <summary>Rule selector data.</summary>
        public CefNet.DevTools.Protocol.CSS.SelectorList SelectorList { get; set; }

        /// <summary>Parent stylesheet's origin.</summary>
        public CefNet.DevTools.Protocol.CSS.StyleSheetOrigin Origin { get; set; }

        /// <summary>Associated style declaration.</summary>
        public CefNet.DevTools.Protocol.CSS.CSSStyle Style { get; set; }

        /// <summary>
        /// Media list array (for rules involving media queries). The array enumerates media queries
        /// starting with the innermost one, going outwards.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.CSS.CSSMedia>? Media { get; set; }

        /// <summary>
        /// [Experimental] Container query list array (for rules involving container queries).
        /// The array enumerates container queries starting with the innermost one, going outwards.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.CSS.CSSContainerQuery>? ContainerQueries { get; set; }
    }
}
