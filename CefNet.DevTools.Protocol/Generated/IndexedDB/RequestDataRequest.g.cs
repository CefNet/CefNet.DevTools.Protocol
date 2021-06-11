//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.IndexedDB
{
    public sealed class RequestDataRequest
    {
        /// <summary>Security origin.</summary>
        public string SecurityOrigin { get; set; }

        /// <summary>Database name.</summary>
        public string DatabaseName { get; set; }

        /// <summary>Object store name.</summary>
        public string ObjectStoreName { get; set; }

        /// <summary>
        /// Index name, empty string for object store data requests.
        /// </summary>
        public string IndexName { get; set; }

        /// <summary>Number of records to skip.</summary>
        public int SkipCount { get; set; }

        /// <summary>Number of records to fetch.</summary>
        public int PageSize { get; set; }

        /// <summary>Key range.</summary>
        public CefNet.DevTools.Protocol.IndexedDB.KeyRange? KeyRange { get; set; }
    }
}
