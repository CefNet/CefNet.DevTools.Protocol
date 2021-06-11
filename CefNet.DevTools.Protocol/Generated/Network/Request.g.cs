//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Network
{
    /// <summary>HTTP request data.</summary>
    public sealed class Request
    {
        /// <summary>Request URL (without fragment).</summary>
        public string Url { get; set; }

        /// <summary>
        /// Fragment of the requested URL starting with hash, if present.
        /// </summary>
        public string? UrlFragment { get; set; }

        /// <summary>HTTP request method.</summary>
        public string Method { get; set; }

        /// <summary>HTTP request headers.</summary>
        public CefNet.DevTools.Protocol.Network.Headers Headers { get; set; }

        /// <summary>HTTP POST request data.</summary>
        public string? PostData { get; set; }

        /// <summary>
        /// True when the request has POST data. Note that postData might still be omitted when this flag is true when the data is too long.
        /// </summary>
        public bool? HasPostData { get; set; }

        /// <summary>
        /// [Experimental] Request body elements. This will be converted from base64 to binary
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Network.PostDataEntry>? PostDataEntries { get; set; }

        /// <summary>The mixed content type of the request.</summary>
        public CefNet.DevTools.Protocol.Security.MixedContentType? MixedContentType { get; set; }

        /// <summary>
        /// Priority of the resource request at the time request is sent.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.ResourcePriority InitialPriority { get; set; }

        /// <summary>
        /// The referrer policy of the request, as defined in https://www.w3.org/TR/referrer-policy/
        /// </summary>
        public CefNet.DevTools.Protocol.Network.RequestReferrerPolicy ReferrerPolicy { get; set; }

        /// <summary>Whether is loaded via link preload.</summary>
        public bool? IsLinkPreload { get; set; }

        /// <summary>
        /// [Experimental] Set for requests when the TrustToken API is used. Contains the parameters
        /// passed by the developer (e.g. via "fetch") as understood by the backend.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.TrustTokenParams? TrustTokenParams { get; set; }
    }
}
