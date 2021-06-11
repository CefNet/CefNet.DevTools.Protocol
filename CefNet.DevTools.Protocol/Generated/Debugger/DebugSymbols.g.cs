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
    /// Debug symbols available for a wasm script.
    /// </summary>
    public sealed class DebugSymbols
    {
        /// <summary>Type of the debug symbols.</summary>
        public CefNet.DevTools.Protocol.Debugger.DebugSymbolsType Type { get; set; }

        /// <summary>URL of the external symbol source.</summary>
        public string? ExternalURL { get; set; }
    }
}
