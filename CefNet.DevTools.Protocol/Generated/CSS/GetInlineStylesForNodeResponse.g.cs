//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.CSS
{
    public sealed class GetInlineStylesForNodeResponse
    {
        /// <summary>Inline style for the specified DOM node.</summary>
        public CefNet.DevTools.Protocol.CSS.CSSStyle? InlineStyle { get; set; }

        /// <summary>
        /// Attribute-defined element style (e.g. resulting from "width=20 height=100%").
        /// </summary>
        public CefNet.DevTools.Protocol.CSS.CSSStyle? AttributesStyle { get; set; }
    }
}
