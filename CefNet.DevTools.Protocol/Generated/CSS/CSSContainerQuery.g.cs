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
    /// [Experimental] CSS container query rule descriptor.
    /// </summary>
    public sealed class CSSContainerQuery
    {
        /// <summary>Container query text.</summary>
        public string Text { get; set; }

        /// <summary>
        /// The associated rule header range in the enclosing stylesheet (if
        /// available).
        /// </summary>
        public CefNet.DevTools.Protocol.CSS.SourceRange? Range { get; set; }

        /// <summary>
        /// Identifier of the stylesheet containing this object (if exists).
        /// </summary>
        public CefNet.DevTools.Protocol.CSS.StyleSheetId? StyleSheetId { get; set; }

        /// <summary>Optional name for the container.</summary>
        public string? Name { get; set; }
    }
}
