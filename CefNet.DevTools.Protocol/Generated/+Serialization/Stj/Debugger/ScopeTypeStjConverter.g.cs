//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Debugger
{
    internal sealed class ScopeTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Debugger.ScopeType>
    {
        public override CefNet.DevTools.Protocol.Debugger.ScopeType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "block" => CefNet.DevTools.Protocol.Debugger.ScopeType.Block,
                "catch" => CefNet.DevTools.Protocol.Debugger.ScopeType.Catch,
                "closure" => CefNet.DevTools.Protocol.Debugger.ScopeType.Closure,
                "eval" => CefNet.DevTools.Protocol.Debugger.ScopeType.Eval,
                "global" => CefNet.DevTools.Protocol.Debugger.ScopeType.Global,
                "local" => CefNet.DevTools.Protocol.Debugger.ScopeType.Local,
                "module" => CefNet.DevTools.Protocol.Debugger.ScopeType.Module,
                "script" => CefNet.DevTools.Protocol.Debugger.ScopeType.Script,
                "wasm-expression-stack" => CefNet.DevTools.Protocol.Debugger.ScopeType.WasmExpressionStack,
                "with" => CefNet.DevTools.Protocol.Debugger.ScopeType.With,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Debugger.ScopeType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
