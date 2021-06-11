//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.CSS
{
    /// <summary>CSS stylesheet metainformation.</summary>
    public sealed class CSSStyleSheetHeader
    {
        /// <summary>The stylesheet identifier.</summary>
        public CefNet.DevTools.Protocol.CSS.StyleSheetId StyleSheetId { get; set; }

        /// <summary>Owner frame identifier.</summary>
        public CefNet.DevTools.Protocol.Page.FrameId FrameId { get; set; }

        /// <summary>Stylesheet resource URL.</summary>
        public string SourceURL { get; set; }

        /// <summary>
        /// URL of source map associated with the stylesheet (if any).
        /// </summary>
        public string? SourceMapURL { get; set; }

        /// <summary>Stylesheet origin.</summary>
        public CefNet.DevTools.Protocol.CSS.StyleSheetOrigin Origin { get; set; }

        /// <summary>Stylesheet title.</summary>
        public string Title { get; set; }

        /// <summary>
        /// The backend id for the owner node of the stylesheet.
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.BackendNodeId? OwnerNode { get; set; }

        /// <summary>
        /// Denotes whether the stylesheet is disabled.
        /// </summary>
        public bool Disabled { get; set; }

        /// <summary>
        /// Whether the sourceURL field value comes from the sourceURL comment.
        /// </summary>
        public bool? HasSourceURL { get; set; }

        /// <summary>
        /// Whether this stylesheet is created for STYLE tag by parser. This flag is not set for
        /// document.written STYLE tags.
        /// </summary>
        public bool IsInline { get; set; }

        /// <summary>
        /// Whether this stylesheet is mutable. Inline stylesheets become mutable
        /// after they have been modified via CSSOM API.
        /// <link> element's stylesheets become mutable only if DevTools modifies them.
        /// Constructed stylesheets (new CSSStyleSheet()) are mutable immediately after creation.
        /// </summary>
        public bool IsMutable { get; set; }

        /// <summary>
        /// Whether this stylesheet is a constructed stylesheet (created using new CSSStyleSheet()).
        /// </summary>
        public bool IsConstructed { get; set; }

        /// <summary>
        /// Line offset of the stylesheet within the resource (zero based).
        /// </summary>
        public double StartLine { get; set; }

        /// <summary>
        /// Column offset of the stylesheet within the resource (zero based).
        /// </summary>
        public double StartColumn { get; set; }

        /// <summary>Size of the content (in characters).</summary>
        public double Length { get; set; }

        /// <summary>
        /// Line offset of the end of the stylesheet within the resource (zero based).
        /// </summary>
        public double EndLine { get; set; }

        /// <summary>
        /// Column offset of the end of the stylesheet within the resource (zero based).
        /// </summary>
        public double EndColumn { get; set; }
    }
}
