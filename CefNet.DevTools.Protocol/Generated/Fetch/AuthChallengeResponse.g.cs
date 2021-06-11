//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Fetch
{
    /// <summary>Response to an AuthChallenge.</summary>
    public sealed class AuthChallengeResponse
    {
        /// <summary>
        /// The decision on what to do in response to the authorization challenge.  Default means
        /// deferring to the default behavior of the net stack, which will likely either the Cancel
        /// authentication or display a popup dialog box.
        /// </summary>
        public CefNet.DevTools.Protocol.Fetch.AuthChallengeResponseResponse Response { get; set; }

        /// <summary>
        /// The username to provide, possibly empty. Should only be set if response is
        /// ProvideCredentials.
        /// </summary>
        public string? Username { get; set; }

        /// <summary>
        /// The password to provide, possibly empty. Should only be set if response is
        /// ProvideCredentials.
        /// </summary>
        public string? Password { get; set; }
    }
}
