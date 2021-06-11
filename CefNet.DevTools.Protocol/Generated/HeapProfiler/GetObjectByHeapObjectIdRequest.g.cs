//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.HeapProfiler
{
    public sealed class GetObjectByHeapObjectIdRequest
    {
        public CefNet.DevTools.Protocol.HeapProfiler.HeapSnapshotObjectId ObjectId { get; set; }

        /// <summary>
        /// Symbolic group name that can be used to release multiple objects.
        /// </summary>
        public string? ObjectGroup { get; set; }
    }
}
