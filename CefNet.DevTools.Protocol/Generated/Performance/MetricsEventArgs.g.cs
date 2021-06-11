//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Performance
{
    public sealed class MetricsEventArgs
        : System.EventArgs
    {
        /// <summary>Current values of the metrics.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Performance.Metric> Metrics { get; set; }

        /// <summary>Timestamp title.</summary>
        public string Title { get; set; }
    }
}
