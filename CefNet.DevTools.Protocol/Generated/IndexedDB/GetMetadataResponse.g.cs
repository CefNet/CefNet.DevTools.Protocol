//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.IndexedDB
{
    public sealed class GetMetadataResponse
    {
        /// <summary>the entries count</summary>
        public double EntriesCount { get; set; }

        /// <summary>
        /// the current value of key generator, to become the next inserted
        /// key into the object store. Valid if objectStore.autoIncrement
        /// is true.
        /// </summary>
        public double KeyGeneratorValue { get; set; }
    }
}
