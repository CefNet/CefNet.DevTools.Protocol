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
    /// [Experimental] A cookie which was not stored from a response with the corresponding reason.
    /// </summary>
    public sealed class BlockedSetCookieWithReason
    {
        /// <summary>The reason(s) this cookie was blocked.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Network.SetCookieBlockedReason> BlockedReasons { get; set; }

        /// <summary>
        /// The string representing this individual cookie as it would appear in the header.
        /// This is not the entire "cookie" or "set-cookie" header which could have multiple cookies.
        /// </summary>
        public string CookieLine { get; set; }

        /// <summary>
        /// The cookie object which represents the cookie which was not stored. It is optional because
        /// sometimes complete cookie information is not available, such as in the case of parsing
        /// errors.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.Cookie? Cookie { get; set; }
    }
}
