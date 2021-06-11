//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.PerformanceTimeline
{
    public sealed class EnableRequest
    {
        /// <summary>
        /// The types of event to report, as specified in
        /// https://w3c.github.io/performance-timeline/#dom-performanceentry-entrytype
        /// The specified filter overrides any previous filters, passing empty
        /// filter disables recording.
        /// Note that not all types exposed to the web platform are currently supported.
        /// </summary>
        public System.Collections.Generic.List<string> EventTypes { get; set; }
    }
}
