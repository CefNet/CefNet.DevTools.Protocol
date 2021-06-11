//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOMSnapshot
{
    public sealed class CaptureSnapshotResponse
    {
        /// <summary>
        /// The nodes in the DOM tree. The DOMNode at index 0 corresponds to the root document.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.DOMSnapshot.DocumentSnapshot> Documents { get; set; }

        /// <summary>
        /// Shared string table that all string properties refer to with indexes.
        /// </summary>
        public System.Collections.Generic.List<string> Strings { get; set; }
    }
}
