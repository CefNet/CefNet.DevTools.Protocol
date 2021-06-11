//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Debugger
{
    /// <summary>
    /// [Experimental] Location range within one script.
    /// </summary>
    public sealed class LocationRange
    {
        public CefNet.DevTools.Protocol.Runtime.ScriptId ScriptId { get; set; }

        public CefNet.DevTools.Protocol.Debugger.ScriptPosition Start { get; set; }

        public CefNet.DevTools.Protocol.Debugger.ScriptPosition End { get; set; }
    }
}
