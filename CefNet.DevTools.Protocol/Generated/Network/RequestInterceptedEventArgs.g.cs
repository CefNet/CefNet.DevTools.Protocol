//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Network
{
    public sealed class RequestInterceptedEventArgs
        : System.EventArgs
    {
        /// <summary>
        /// Each request the page makes will have a unique id, however if any redirects are encountered
        /// while processing that fetch, they will be reported with the same id as the original fetch.
        /// Likewise if HTTP authentication is needed then the same fetch id will be used.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.InterceptionId InterceptionId { get; set; }

        public CefNet.DevTools.Protocol.Network.Request Request { get; set; }

        /// <summary>
        /// The id of the frame that initiated the request.
        /// </summary>
        public CefNet.DevTools.Protocol.Page.FrameId FrameId { get; set; }

        /// <summary>How the requested resource will be used.</summary>
        public CefNet.DevTools.Protocol.Network.ResourceType ResourceType { get; set; }

        /// <summary>
        /// Whether this is a navigation request, which can abort the navigation completely.
        /// </summary>
        public bool IsNavigationRequest { get; set; }

        /// <summary>
        /// Set if the request is a navigation that will result in a download.
        /// Only present after response is received from the server (i.e. HeadersReceived stage).
        /// </summary>
        public bool? IsDownload { get; set; }

        /// <summary>
        /// Redirect location, only sent if a redirect was intercepted.
        /// </summary>
        public string? RedirectUrl { get; set; }

        /// <summary>
        /// Details of the Authorization Challenge encountered. If this is set then
        /// continueInterceptedRequest must contain an authChallengeResponse.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.AuthChallenge? AuthChallenge { get; set; }

        /// <summary>
        /// Response error if intercepted at response stage or if redirect occurred while intercepting
        /// request.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.ErrorReason? ResponseErrorReason { get; set; }

        /// <summary>
        /// Response code if intercepted at response stage or if redirect occurred while intercepting
        /// request or auth retry occurred.
        /// </summary>
        public int? ResponseStatusCode { get; set; }

        /// <summary>
        /// Response headers if intercepted at the response stage or if redirect occurred while
        /// intercepting request or auth retry occurred.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.Headers? ResponseHeaders { get; set; }

        /// <summary>
        /// If the intercepted request had a corresponding requestWillBeSent event fired for it, then
        /// this requestId will be the same as the requestId present in the requestWillBeSent event.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.RequestId? RequestId { get; set; }
    }
}
