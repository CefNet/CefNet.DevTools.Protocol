//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.IndexedDB
{
    /// <summary>Object store.</summary>
    public sealed class ObjectStore
    {
        /// <summary>Object store name.</summary>
        public string Name { get; set; }

        /// <summary>Object store key path.</summary>
        public CefNet.DevTools.Protocol.IndexedDB.KeyPath KeyPath { get; set; }

        /// <summary>
        /// If true, object store has auto increment flag set.
        /// </summary>
        public bool AutoIncrement { get; set; }

        /// <summary>Indexes in this object store.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.IndexedDB.ObjectStoreIndex> Indexes { get; set; }
    }
}
