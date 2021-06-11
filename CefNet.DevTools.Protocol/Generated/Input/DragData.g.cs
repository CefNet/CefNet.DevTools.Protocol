//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Input
{
    /// <summary>[Experimental] </summary>
    public sealed class DragData
    {
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Input.DragDataItem> Items { get; set; }

        /// <summary>
        /// Bit field representing allowed drag operations. Copy = 1, Link = 2, Move = 16
        /// </summary>
        public int DragOperationsMask { get; set; }
    }
}
