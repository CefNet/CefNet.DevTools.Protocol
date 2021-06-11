//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.LayerTree
{
    public sealed class ProfileSnapshotRequest
    {
        /// <summary>The id of the layer snapshot.</summary>
        public CefNet.DevTools.Protocol.LayerTree.SnapshotId SnapshotId { get; set; }

        /// <summary>
        /// The maximum number of times to replay the snapshot (1, if not specified).
        /// </summary>
        public int? MinRepeatCount { get; set; }

        /// <summary>
        /// The minimum duration (in seconds) to replay the snapshot.
        /// </summary>
        public double? MinDuration { get; set; }

        /// <summary>
        /// The clip rectangle to apply when replaying the snapshot.
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.Rect? ClipRect { get; set; }
    }
}
