//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.CacheStorage
{
    public sealed class RequestEntriesResponse
    {
        /// <summary>Array of object store data entries.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.CacheStorage.DataEntry> CacheDataEntries { get; set; }

        /// <summary>
        /// Count of returned entries from this storage. If pathFilter is empty, it
        /// is the count of all entries from this storage.
        /// </summary>
        public double ReturnCount { get; set; }
    }
}
