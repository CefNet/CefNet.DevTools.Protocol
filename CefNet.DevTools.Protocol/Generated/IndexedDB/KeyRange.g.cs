//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.IndexedDB
{
    /// <summary>Key range.</summary>
    public sealed class KeyRange
    {
        /// <summary>Lower bound.</summary>
        public CefNet.DevTools.Protocol.IndexedDB.Key? Lower { get; set; }

        /// <summary>Upper bound.</summary>
        public CefNet.DevTools.Protocol.IndexedDB.Key? Upper { get; set; }

        /// <summary>If true lower bound is open.</summary>
        public bool LowerOpen { get; set; }

        /// <summary>If true upper bound is open.</summary>
        public bool UpperOpen { get; set; }
    }
}
