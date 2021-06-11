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
    /// Details of post layout rendered text positions. The exact layout should not be regarded as
    /// stable and may change between versions.
    /// </summary>
    public sealed class InlineTextBox
    {
        /// <summary>
        /// The bounding box in document coordinates. Note that scroll offset of the document is ignored.
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.Rect BoundingBox { get; set; }

        /// <summary>
        /// The starting index in characters, for this post layout textbox substring. Characters that
        /// would be represented as a surrogate pair in UTF-16 have length 2.
        /// </summary>
        public int StartCharacterIndex { get; set; }

        /// <summary>
        /// The number of characters in this post layout textbox substring. Characters that would be
        /// represented as a surrogate pair in UTF-16 have length 2.
        /// </summary>
        public int NumCharacters { get; set; }
    }
}
