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
    /// A descriptor of operation to mutate style declaration text.
    /// </summary>
    public sealed class StyleDeclarationEdit
    {
        /// <summary>The css style sheet identifier.</summary>
        public CefNet.DevTools.Protocol.CSS.StyleSheetId StyleSheetId { get; set; }

        /// <summary>
        /// The range of the style text in the enclosing stylesheet.
        /// </summary>
        public CefNet.DevTools.Protocol.CSS.SourceRange Range { get; set; }

        /// <summary>New style text.</summary>
        public string Text { get; set; }
    }
}
