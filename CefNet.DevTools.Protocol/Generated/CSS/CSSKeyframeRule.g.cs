//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.CSS
{
    /// <summary>CSS keyframe rule representation.</summary>
    public sealed class CSSKeyframeRule
    {
        /// <summary>
        /// The css style sheet identifier (absent for user agent stylesheet and user-specified
        /// stylesheet rules) this rule came from.
        /// </summary>
        public CefNet.DevTools.Protocol.CSS.StyleSheetId? StyleSheetId { get; set; }

        /// <summary>Parent stylesheet's origin.</summary>
        public CefNet.DevTools.Protocol.CSS.StyleSheetOrigin Origin { get; set; }

        /// <summary>Associated key text.</summary>
        public CefNet.DevTools.Protocol.CSS.Value KeyText { get; set; }

        /// <summary>Associated style declaration.</summary>
        public CefNet.DevTools.Protocol.CSS.CSSStyle Style { get; set; }
    }
}
