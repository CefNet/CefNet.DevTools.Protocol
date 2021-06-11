//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.CacheStorage
{
    public sealed class DeleteEntryRequest
    {
        /// <summary>
        /// Id of cache where the entry will be deleted.
        /// </summary>
        public CefNet.DevTools.Protocol.CacheStorage.CacheId CacheId { get; set; }

        /// <summary>URL spec of the request.</summary>
        public string Request { get; set; }
    }
}
