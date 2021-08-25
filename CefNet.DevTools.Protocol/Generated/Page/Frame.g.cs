//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    /// <summary>Information about the Frame on the page.</summary>
    public sealed class Frame
    {
        /// <summary>Frame unique identifier.</summary>
        public CefNet.DevTools.Protocol.Page.FrameId Id { get; set; }

        /// <summary>Parent frame identifier.</summary>
        public string? ParentId { get; set; }

        /// <summary>
        /// Identifier of the loader associated with this frame.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.LoaderId LoaderId { get; set; }

        /// <summary>Frame's name as specified in the tag.</summary>
        public string? Name { get; set; }

        /// <summary>Frame document's URL without fragment.</summary>
        public string Url { get; set; }

        /// <summary>
        /// [Experimental] Frame document's URL fragment including the '#'.
        /// </summary>
        public string? UrlFragment { get; set; }

        /// <summary>
        /// [Experimental] Frame document's registered domain, taking the public suffixes list into account.
        /// Extracted from the Frame's url.
        /// Example URLs: http://www.google.com/file.html -> "google.com"
        /// http://a.b.co.uk/file.html      -> "b.co.uk"
        /// </summary>
        public string DomainAndRegistry { get; set; }

        /// <summary>Frame document's security origin.</summary>
        public string SecurityOrigin { get; set; }

        /// <summary>
        /// Frame document's mimeType as determined by the browser.
        /// </summary>
        public string MimeType { get; set; }

        /// <summary>
        /// [Experimental] If the frame failed to load, this contains the URL that could not be loaded. Note that unlike url above, this URL may contain a fragment.
        /// </summary>
        public string? UnreachableUrl { get; set; }

        /// <summary>
        /// [Experimental] Indicates whether this frame was tagged as an ad and why.
        /// </summary>
        public CefNet.DevTools.Protocol.Page.AdFrameStatus? AdFrameStatus { get; set; }

        /// <summary>
        /// [Experimental] Indicates whether the main document is a secure context and explains why that is the case.
        /// </summary>
        public CefNet.DevTools.Protocol.Page.SecureContextType SecureContextType { get; set; }

        /// <summary>
        /// [Experimental] Indicates whether this is a cross origin isolated context.
        /// </summary>
        public CefNet.DevTools.Protocol.Page.CrossOriginIsolatedContextType CrossOriginIsolatedContextType { get; set; }

        /// <summary>
        /// [Experimental] Indicated which gated APIs / features are available.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Page.GatedAPIFeatures> GatedAPIFeatures { get; set; }

        /// <summary>
        /// [Experimental] Frame document's origin trials with at least one token present.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Page.OriginTrial>? OriginTrials { get; set; }
    }
}
