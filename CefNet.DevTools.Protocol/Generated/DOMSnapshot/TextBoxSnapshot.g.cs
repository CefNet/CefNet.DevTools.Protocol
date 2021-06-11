//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOMSnapshot
{
    /// <summary>
    /// Table of details of the post layout rendered text positions. The exact layout should not be regarded as
    /// stable and may change between versions.
    /// </summary>
    public sealed class TextBoxSnapshot
    {
        /// <summary>
        /// Index of the layout tree node that owns this box collection.
        /// </summary>
        public System.Collections.Generic.List<int> LayoutIndex { get; set; }

        /// <summary>The absolute position bounding box.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.DOMSnapshot.Rectangle> Bounds { get; set; }

        /// <summary>
        /// The starting index in characters, for this post layout textbox substring. Characters that
        /// would be represented as a surrogate pair in UTF-16 have length 2.
        /// </summary>
        public System.Collections.Generic.List<int> Start { get; set; }

        /// <summary>
        /// The number of characters in this post layout textbox substring. Characters that would be
        /// represented as a surrogate pair in UTF-16 have length 2.
        /// </summary>
        public System.Collections.Generic.List<int> Length { get; set; }
    }
}
