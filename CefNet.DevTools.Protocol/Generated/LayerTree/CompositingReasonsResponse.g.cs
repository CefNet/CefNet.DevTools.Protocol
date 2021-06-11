//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.LayerTree
{
    public sealed class CompositingReasonsResponse
    {
        /// <summary>
        /// [Deprecated] A list of strings specifying reasons for the given layer to become composited.
        /// </summary>
        [Obsolete]
        public System.Collections.Generic.List<string> CompositingReasons { get; set; }

        /// <summary>
        /// A list of strings specifying reason IDs for the given layer to become composited.
        /// </summary>
        public System.Collections.Generic.List<string> CompositingReasonIds { get; set; }
    }
}
