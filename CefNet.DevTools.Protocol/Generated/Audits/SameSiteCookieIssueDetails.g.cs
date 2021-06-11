//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Audits
{
    /// <summary>
    /// This information is currently necessary, as the front-end has a difficult
    /// time finding a specific cookie. With this, we can convey specific error
    /// information without the cookie.
    /// </summary>
    public sealed class SameSiteCookieIssueDetails
    {
        /// <summary>
        /// If AffectedCookie is not set then rawCookieLine contains the raw
        /// Set-Cookie header string. This hints at a problem where the
        /// cookie line is syntactically or semantically malformed in a way
        /// that no valid cookie could be created.
        /// </summary>
        public CefNet.DevTools.Protocol.Audits.AffectedCookie? Cookie { get; set; }

        public string? RawCookieLine { get; set; }

        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Audits.SameSiteCookieWarningReason> CookieWarningReasons { get; set; }

        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Audits.SameSiteCookieExclusionReason> CookieExclusionReasons { get; set; }

        /// <summary>
        /// Optionally identifies the site-for-cookies and the cookie url, which
        /// may be used by the front-end as additional context.
        /// </summary>
        public CefNet.DevTools.Protocol.Audits.SameSiteCookieOperation Operation { get; set; }

        public string? SiteForCookies { get; set; }

        public string? CookieUrl { get; set; }

        public CefNet.DevTools.Protocol.Audits.AffectedRequest? Request { get; set; }
    }
}
