//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Fetch
{
    public sealed class EnableRequest
    {
        /// <summary>
        /// If specified, only requests matching any of these patterns will produce
        /// fetchRequested event and will be paused until clients response. If not set,
        /// all requests will be affected.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Fetch.RequestPattern>? Patterns { get; set; }

        /// <summary>
        /// If true, authRequired events will be issued and requests will be paused
        /// expecting a call to continueWithAuth.
        /// </summary>
        public bool? HandleAuthRequests { get; set; }
    }
}
