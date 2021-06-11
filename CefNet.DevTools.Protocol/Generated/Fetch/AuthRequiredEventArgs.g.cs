//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Fetch
{
    public sealed class AuthRequiredEventArgs
        : System.EventArgs
    {
        /// <summary>
        /// Each request the page makes will have a unique id.
        /// </summary>
        public CefNet.DevTools.Protocol.Fetch.RequestId RequestId { get; set; }

        /// <summary>The details of the request.</summary>
        public CefNet.DevTools.Protocol.Network.Request Request { get; set; }

        /// <summary>
        /// The id of the frame that initiated the request.
        /// </summary>
        public CefNet.DevTools.Protocol.Page.FrameId FrameId { get; set; }

        /// <summary>How the requested resource will be used.</summary>
        public CefNet.DevTools.Protocol.Network.ResourceType ResourceType { get; set; }

        /// <summary>
        /// Details of the Authorization Challenge encountered.
        /// If this is set, client should respond with continueRequest that
        /// contains AuthChallengeResponse.
        /// </summary>
        public CefNet.DevTools.Protocol.Fetch.AuthChallenge AuthChallenge { get; set; }
    }
}
