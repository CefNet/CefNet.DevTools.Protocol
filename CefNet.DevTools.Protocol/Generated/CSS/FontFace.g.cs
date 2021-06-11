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
    /// Properties of a web font: https://www.w3.org/TR/2008/REC-CSS2-20080411/fonts.html#font-descriptions
    /// and additional information such as platformFontFamily and fontVariationAxes.
    /// </summary>
    public sealed class FontFace
    {
        /// <summary>The font-family.</summary>
        public string FontFamily { get; set; }

        /// <summary>The font-style.</summary>
        public string FontStyle { get; set; }

        /// <summary>The font-variant.</summary>
        public string FontVariant { get; set; }

        /// <summary>The font-weight.</summary>
        public string FontWeight { get; set; }

        /// <summary>The font-stretch.</summary>
        public string FontStretch { get; set; }

        /// <summary>The unicode-range.</summary>
        public string UnicodeRange { get; set; }

        /// <summary>The src.</summary>
        public string Src { get; set; }

        /// <summary>The resolved platform font family</summary>
        public string PlatformFontFamily { get; set; }

        /// <summary>
        /// Available variation settings (a.k.a. "axes").
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.CSS.FontVariationAxis>? FontVariationAxes { get; set; }
    }
}
