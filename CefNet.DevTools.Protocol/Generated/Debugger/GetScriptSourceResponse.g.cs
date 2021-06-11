//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Debugger
{
    public sealed class GetScriptSourceResponse
    {
        /// <summary>
        /// Script source (empty in case of Wasm bytecode).
        /// </summary>
        public string ScriptSource { get; set; }

        /// <summary>Wasm bytecode.</summary>
        public byte[]? Bytecode { get; set; }
    }
}
