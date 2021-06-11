//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Network
{
    /// <summary>
    /// [Experimental] A cookie with was not sent with a request with the corresponding reason.
    /// </summary>
    public sealed class BlockedCookieWithReason
    {
        /// <summary>The reason(s) the cookie was blocked.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Network.CookieBlockedReason> BlockedReasons { get; set; }

        /// <summary>
        /// The cookie object representing the cookie which was not sent.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.Cookie Cookie { get; set; }
    }
}
