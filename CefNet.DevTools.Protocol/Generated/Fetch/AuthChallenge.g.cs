//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Fetch
{
    /// <summary>
    /// Authorization challenge for HTTP status code 401 or 407.
    /// </summary>
    public sealed class AuthChallenge
    {
        /// <summary>Source of the authentication challenge.</summary>
        public CefNet.DevTools.Protocol.Fetch.AuthChallengeSource? Source { get; set; }

        /// <summary>Origin of the challenger.</summary>
        public string Origin { get; set; }

        /// <summary>
        /// The authentication scheme used, such as basic or digest
        /// </summary>
        public string Scheme { get; set; }

        /// <summary>
        /// The realm of the challenge. May be empty.
        /// </summary>
        public string Realm { get; set; }
    }
}
