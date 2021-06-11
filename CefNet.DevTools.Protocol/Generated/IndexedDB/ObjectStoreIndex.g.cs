//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.IndexedDB
{
    /// <summary>Object store index.</summary>
    public sealed class ObjectStoreIndex
    {
        /// <summary>Index name.</summary>
        public string Name { get; set; }

        /// <summary>Index key path.</summary>
        public CefNet.DevTools.Protocol.IndexedDB.KeyPath KeyPath { get; set; }

        /// <summary>If true, index is unique.</summary>
        public bool Unique { get; set; }

        /// <summary>
        /// If true, index allows multiple entries for a key.
        /// </summary>
        public bool MultiEntry { get; set; }
    }
}
