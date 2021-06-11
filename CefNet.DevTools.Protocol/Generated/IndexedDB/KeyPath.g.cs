//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.IndexedDB
{
    /// <summary>Key path.</summary>
    public sealed class KeyPath
    {
        /// <summary>Key path type.</summary>
        public CefNet.DevTools.Protocol.IndexedDB.KeyPathType Type { get; set; }

        /// <summary>String value.</summary>
        public string? String { get; set; }

        /// <summary>Array value.</summary>
        public System.Collections.Generic.List<string>? Array { get; set; }
    }
}
