//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.IndexedDB
{
    public sealed class DeleteObjectStoreEntriesRequest
    {
        public string SecurityOrigin { get; set; }

        public string DatabaseName { get; set; }

        public string ObjectStoreName { get; set; }

        /// <summary>Range of entry keys to delete</summary>
        public CefNet.DevTools.Protocol.IndexedDB.KeyRange KeyRange { get; set; }
    }
}
