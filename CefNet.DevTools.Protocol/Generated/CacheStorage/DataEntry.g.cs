//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.CacheStorage
{
    /// <summary>Data entry.</summary>
    public sealed class DataEntry
    {
        /// <summary>Request URL.</summary>
        public string RequestURL { get; set; }

        /// <summary>Request method.</summary>
        public string RequestMethod { get; set; }

        /// <summary>Request headers</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.CacheStorage.Header> RequestHeaders { get; set; }

        /// <summary>Number of seconds since epoch.</summary>
        public double ResponseTime { get; set; }

        /// <summary>HTTP response status code.</summary>
        public int ResponseStatus { get; set; }

        /// <summary>HTTP response status text.</summary>
        public string ResponseStatusText { get; set; }

        /// <summary>HTTP response type</summary>
        public CefNet.DevTools.Protocol.CacheStorage.CachedResponseType ResponseType { get; set; }

        /// <summary>Response headers</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.CacheStorage.Header> ResponseHeaders { get; set; }
    }
}
