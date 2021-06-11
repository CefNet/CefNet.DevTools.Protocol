//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOM
{
    public sealed class PerformSearchRequest
    {
        /// <summary>
        /// Plain text or query selector or XPath search query.
        /// </summary>
        public string Query { get; set; }

        /// <summary>True to search in user agent shadow DOM.</summary>
        public bool? IncludeUserAgentShadowDOM { get; set; }
    }
}
