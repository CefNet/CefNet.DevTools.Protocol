//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.IndexedDB
{
    /// <summary>Key.</summary>
    public sealed class Key
    {
        /// <summary>Key type.</summary>
        public CefNet.DevTools.Protocol.IndexedDB.KeyType Type { get; set; }

        /// <summary>Number value.</summary>
        public double? Number { get; set; }

        /// <summary>String value.</summary>
        public string? String { get; set; }

        /// <summary>Date value.</summary>
        public double? Date { get; set; }

        /// <summary>Array value.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.IndexedDB.Key>? Array { get; set; }
    }
}
