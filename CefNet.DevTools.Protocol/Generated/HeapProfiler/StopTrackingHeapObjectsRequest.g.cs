//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.HeapProfiler
{
    public sealed class StopTrackingHeapObjectsRequest
    {
        /// <summary>
        /// If true 'reportHeapSnapshotProgress' events will be generated while snapshot is being taken
        /// when the tracking is stopped.
        /// </summary>
        public bool? ReportProgress { get; set; }

        public bool? TreatGlobalObjectsAsRoots { get; set; }
    }
}
