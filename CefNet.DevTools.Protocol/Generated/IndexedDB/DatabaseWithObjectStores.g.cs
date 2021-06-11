//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.IndexedDB
{
    /// <summary>Database with an array of object stores.</summary>
    public sealed class DatabaseWithObjectStores
    {
        /// <summary>Database name.</summary>
        public string Name { get; set; }

        /// <summary>
        /// Database version (type is not 'integer', as the standard
        /// requires the version number to be 'unsigned long long')
        /// </summary>
        public double Version { get; set; }

        /// <summary>Object stores in this database.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.IndexedDB.ObjectStore> ObjectStores { get; set; }
    }
}
