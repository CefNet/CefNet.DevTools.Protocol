//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.LayerTree
{
    public sealed class ReplaySnapshotRequest
    {
        /// <summary>The id of the layer snapshot.</summary>
        public CefNet.DevTools.Protocol.LayerTree.SnapshotId SnapshotId { get; set; }

        /// <summary>
        /// The first step to replay from (replay from the very start if not specified).
        /// </summary>
        public int? FromStep { get; set; }

        /// <summary>
        /// The last step to replay to (replay till the end if not specified).
        /// </summary>
        public int? ToStep { get; set; }

        /// <summary>
        /// The scale to apply while replaying (defaults to 1).
        /// </summary>
        public double? Scale { get; set; }
    }
}
