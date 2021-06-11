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
    /// Information about amount of glyphs that were rendered with given font.
    /// </summary>
    public sealed class PlatformFontUsage
    {
        /// <summary>Font's family name reported by platform.</summary>
        public string FamilyName { get; set; }

        /// <summary>
        /// Indicates if the font was downloaded or resolved locally.
        /// </summary>
        public bool IsCustomFont { get; set; }

        /// <summary>
        /// Amount of glyphs that were rendered with this font.
        /// </summary>
        public double GlyphCount { get; set; }
    }
}
