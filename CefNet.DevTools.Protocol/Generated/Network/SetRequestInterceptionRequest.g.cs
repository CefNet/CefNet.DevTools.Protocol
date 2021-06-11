//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Network
{
    public sealed class SetRequestInterceptionRequest
    {
        /// <summary>
        /// Requests matching any of these patterns will be forwarded and wait for the corresponding
        /// continueInterceptedRequest call.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Network.RequestPattern> Patterns { get; set; }
    }
}
