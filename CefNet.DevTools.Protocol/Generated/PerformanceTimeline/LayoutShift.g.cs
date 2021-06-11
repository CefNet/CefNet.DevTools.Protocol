//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.PerformanceTimeline
{
    /// <summary>
    /// See https://wicg.github.io/layout-instability/#sec-layout-shift and layout_shift.idl
    /// </summary>
    public sealed class LayoutShift
    {
        /// <summary>Score increment produced by this event.</summary>
        public double Value { get; set; }

        public bool HadRecentInput { get; set; }

        public CefNet.DevTools.Protocol.Network.TimeSinceEpoch LastInputTime { get; set; }

        public System.Collections.Generic.List<CefNet.DevTools.Protocol.PerformanceTimeline.LayoutShiftAttribution> Sources { get; set; }
    }
}
