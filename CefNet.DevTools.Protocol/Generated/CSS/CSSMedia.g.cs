//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.CSS
{
    /// <summary>CSS media rule descriptor.</summary>
    public sealed class CSSMedia
    {
        /// <summary>Media query text.</summary>
        public string Text { get; set; }

        /// <summary>
        /// Source of the media query: "mediaRule" if specified by a @media rule, "importRule" if
        /// specified by an @import rule, "linkedSheet" if specified by a "media" attribute in a linked
        /// stylesheet's LINK tag, "inlineSheet" if specified by a "media" attribute in an inline
        /// stylesheet's STYLE tag.
        /// </summary>
        public CefNet.DevTools.Protocol.CSS.CSSMediaSource Source { get; set; }

        /// <summary>
        /// URL of the document containing the media query description.
        /// </summary>
        public string? SourceURL { get; set; }

        /// <summary>
        /// The associated rule (@media or @import) header range in the enclosing stylesheet (if
        /// available).
        /// </summary>
        public CefNet.DevTools.Protocol.CSS.SourceRange? Range { get; set; }

        /// <summary>
        /// Identifier of the stylesheet containing this object (if exists).
        /// </summary>
        public CefNet.DevTools.Protocol.CSS.StyleSheetId? StyleSheetId { get; set; }

        /// <summary>Array of media queries.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.CSS.MediaQuery>? MediaList { get; set; }
    }
}
