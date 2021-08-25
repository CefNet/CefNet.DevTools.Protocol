//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.HeapProfiler
{
    public sealed class TakeHeapSnapshotRequest
    {
        /// <summary>
        /// If true 'reportHeapSnapshotProgress' events will be generated while snapshot is being taken.
        /// </summary>
        public bool? ReportProgress { get; set; }

        /// <summary>
        /// If true, a raw snapshot without artificial roots will be generated
        /// </summary>
        public bool? TreatGlobalObjectsAsRoots { get; set; }

        /// <summary>
        /// If true, numerical values are included in the snapshot
        /// </summary>
        public bool? CaptureNumericValue { get; set; }
    }
}
