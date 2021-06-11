//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Storage
{
    public sealed class IndexedDBContentUpdatedEventArgs
        : System.EventArgs
    {
        /// <summary>Origin to update.</summary>
        public string Origin { get; set; }

        /// <summary>Database to update.</summary>
        public string DatabaseName { get; set; }

        /// <summary>ObjectStore to update.</summary>
        public string ObjectStoreName { get; set; }
    }
}
