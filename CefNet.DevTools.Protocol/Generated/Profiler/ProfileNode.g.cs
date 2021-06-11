//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Profiler
{
    /// <summary>
    /// Profile node. Holds callsite information, execution statistics and child nodes.
    /// </summary>
    public sealed class ProfileNode
    {
        /// <summary>Unique id of the node.</summary>
        public int Id { get; set; }

        /// <summary>Function location.</summary>
        public CefNet.DevTools.Protocol.Runtime.CallFrame CallFrame { get; set; }

        /// <summary>
        /// Number of samples where this node was on top of the call stack.
        /// </summary>
        public int? HitCount { get; set; }

        /// <summary>Child node ids.</summary>
        public System.Collections.Generic.List<int>? Children { get; set; }

        /// <summary>
        /// The reason of being not optimized. The function may be deoptimized or marked as don't
        /// optimize.
        /// </summary>
        public string? DeoptReason { get; set; }

        /// <summary>An array of source position ticks.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Profiler.PositionTickInfo>? PositionTicks { get; set; }
    }
}
