//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.CacheStorage
{
    /// <summary>Cache identifier.</summary>
    public sealed class Cache
    {
        /// <summary>An opaque unique id of the cache.</summary>
        public CefNet.DevTools.Protocol.CacheStorage.CacheId CacheId { get; set; }

        /// <summary>Security origin of the cache.</summary>
        public string SecurityOrigin { get; set; }

        /// <summary>The name of the cache.</summary>
        public string CacheName { get; set; }
    }
}
