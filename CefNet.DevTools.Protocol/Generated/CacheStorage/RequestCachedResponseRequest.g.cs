//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.CacheStorage
{
    public sealed class RequestCachedResponseRequest
    {
        /// <summary>Id of cache that contains the entry.</summary>
        public CefNet.DevTools.Protocol.CacheStorage.CacheId CacheId { get; set; }

        /// <summary>URL spec of the request.</summary>
        public string RequestURL { get; set; }

        /// <summary>headers of the request.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.CacheStorage.Header> RequestHeaders { get; set; }
    }
}
