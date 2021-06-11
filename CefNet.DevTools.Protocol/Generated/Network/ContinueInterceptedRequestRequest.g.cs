//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Network
{
    public sealed class ContinueInterceptedRequestRequest
    {
        public CefNet.DevTools.Protocol.Network.InterceptionId InterceptionId { get; set; }

        /// <summary>
        /// If set this causes the request to fail with the given reason. Passing `Aborted` for requests
        /// marked with `isNavigationRequest` also cancels the navigation. Must not be set in response
        /// to an authChallenge.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.ErrorReason? ErrorReason { get; set; }

        /// <summary>
        /// If set the requests completes using with the provided base64 encoded raw response, including
        /// HTTP status line and headers etc... Must not be set in response to an authChallenge.
        /// </summary>
        public byte[]? RawResponse { get; set; }

        /// <summary>
        /// If set the request url will be modified in a way that's not observable by page. Must not be
        /// set in response to an authChallenge.
        /// </summary>
        public string? Url { get; set; }

        /// <summary>
        /// If set this allows the request method to be overridden. Must not be set in response to an
        /// authChallenge.
        /// </summary>
        public string? Method { get; set; }

        /// <summary>
        /// If set this allows postData to be set. Must not be set in response to an authChallenge.
        /// </summary>
        public string? PostData { get; set; }

        /// <summary>
        /// If set this allows the request headers to be changed. Must not be set in response to an
        /// authChallenge.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.Headers? Headers { get; set; }

        /// <summary>
        /// Response to a requestIntercepted with an authChallenge. Must not be set otherwise.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.AuthChallengeResponse? AuthChallengeResponse { get; set; }
    }
}
