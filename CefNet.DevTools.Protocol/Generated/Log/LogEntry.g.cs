//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Log
{
    /// <summary>Log entry.</summary>
    public sealed class LogEntry
    {
        /// <summary>Log entry source.</summary>
        public CefNet.DevTools.Protocol.Log.LogEntrySource Source { get; set; }

        /// <summary>Log entry severity.</summary>
        public CefNet.DevTools.Protocol.Log.LogEntryLevel Level { get; set; }

        /// <summary>Logged text.</summary>
        public string Text { get; set; }

        /// <summary>Timestamp when this entry was added.</summary>
        public CefNet.DevTools.Protocol.Runtime.Timestamp Timestamp { get; set; }

        /// <summary>URL of the resource if known.</summary>
        public string? Url { get; set; }

        /// <summary>Line number in the resource.</summary>
        public int? LineNumber { get; set; }

        /// <summary>JavaScript stack trace.</summary>
        public CefNet.DevTools.Protocol.Runtime.StackTrace? StackTrace { get; set; }

        /// <summary>
        /// Identifier of the network request associated with this entry.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.RequestId? NetworkRequestId { get; set; }

        /// <summary>
        /// Identifier of the worker associated with this entry.
        /// </summary>
        public string? WorkerId { get; set; }

        /// <summary>Call arguments.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Runtime.RemoteObject>? Args { get; set; }
    }
}
