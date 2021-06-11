//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOMDebugger
{
    /// <summary>Object event listener.</summary>
    public sealed class EventListener
    {
        /// <summary>`EventListener`'s type.</summary>
        public string Type { get; set; }

        /// <summary>`EventListener`'s useCapture.</summary>
        public bool UseCapture { get; set; }

        /// <summary>`EventListener`'s passive flag.</summary>
        public bool Passive { get; set; }

        /// <summary>`EventListener`'s once flag.</summary>
        public bool Once { get; set; }

        /// <summary>Script id of the handler code.</summary>
        public CefNet.DevTools.Protocol.Runtime.ScriptId ScriptId { get; set; }

        /// <summary>Line number in the script (0-based).</summary>
        public int LineNumber { get; set; }

        /// <summary>Column number in the script (0-based).</summary>
        public int ColumnNumber { get; set; }

        /// <summary>Event handler function value.</summary>
        public CefNet.DevTools.Protocol.Runtime.RemoteObject? Handler { get; set; }

        /// <summary>Event original handler function value.</summary>
        public CefNet.DevTools.Protocol.Runtime.RemoteObject? OriginalHandler { get; set; }

        /// <summary>Node the listener is added to (if any).</summary>
        public CefNet.DevTools.Protocol.DOM.BackendNodeId? BackendNodeId { get; set; }
    }
}
