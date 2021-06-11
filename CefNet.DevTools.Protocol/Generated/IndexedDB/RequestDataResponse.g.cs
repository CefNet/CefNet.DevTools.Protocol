//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.IndexedDB
{
    public sealed class RequestDataResponse
    {
        /// <summary>Array of object store data entries.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.IndexedDB.DataEntry> ObjectStoreDataEntries { get; set; }

        /// <summary>
        /// If true, there are more entries to fetch in the given range.
        /// </summary>
        public bool HasMore { get; set; }
    }
}
