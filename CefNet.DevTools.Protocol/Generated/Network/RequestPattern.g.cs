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
    /// [Experimental] Request pattern for interception.
    /// </summary>
    public sealed class RequestPattern
    {
        /// <summary>
        /// Wildcards (`'*'` -> zero or more, `'?'` -> exactly one) are allowed. Escape character is
        /// backslash. Omitting is equivalent to `"*"`.
        /// </summary>
        public string? UrlPattern { get; set; }

        /// <summary>
        /// If set, only requests for matching resource types will be intercepted.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.ResourceType? ResourceType { get; set; }

        /// <summary>
        /// Stage at which to begin intercepting requests. Default is Request.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.InterceptionStage? InterceptionStage { get; set; }
    }
}
