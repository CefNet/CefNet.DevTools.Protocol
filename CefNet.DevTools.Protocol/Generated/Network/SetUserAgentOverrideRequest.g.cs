//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Network
{
    public sealed class SetUserAgentOverrideRequest
    {
        /// <summary>User agent to use.</summary>
        public string UserAgent { get; set; }

        /// <summary>Browser langugage to emulate.</summary>
        public string? AcceptLanguage { get; set; }

        /// <summary>
        /// The platform navigator.platform should return.
        /// </summary>
        public string? Platform { get; set; }

        /// <summary>
        /// [Experimental] To be sent in Sec-CH-UA-* headers and returned in navigator.userAgentData
        /// </summary>
        public CefNet.DevTools.Protocol.Emulation.UserAgentMetadata? UserAgentMetadata { get; set; }
    }
}
