//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.CacheStorage
{
    public sealed class RequestEntriesRequest
    {
        /// <summary>ID of cache to get entries from.</summary>
        public CefNet.DevTools.Protocol.CacheStorage.CacheId CacheId { get; set; }

        /// <summary>Number of records to skip.</summary>
        public int? SkipCount { get; set; }

        /// <summary>Number of records to fetch.</summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// If present, only return the entries containing this substring in the path
        /// </summary>
        public string? PathFilter { get; set; }
    }
}
