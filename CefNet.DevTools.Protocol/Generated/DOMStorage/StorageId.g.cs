//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOMStorage
{
    /// <summary>DOM Storage identifier.</summary>
    public sealed class StorageId
    {
        /// <summary>Security origin for the storage.</summary>
        public string SecurityOrigin { get; set; }

        /// <summary>
        /// Whether the storage is local storage (not session storage).
        /// </summary>
        public bool IsLocalStorage { get; set; }
    }
}
