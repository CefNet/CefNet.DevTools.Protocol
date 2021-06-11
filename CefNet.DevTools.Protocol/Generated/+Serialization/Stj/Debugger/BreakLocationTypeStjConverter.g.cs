//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Debugger
{
    internal sealed class BreakLocationTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Debugger.BreakLocationType>
    {
        public override CefNet.DevTools.Protocol.Debugger.BreakLocationType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "call" => CefNet.DevTools.Protocol.Debugger.BreakLocationType.Call,
                "debuggerStatement" => CefNet.DevTools.Protocol.Debugger.BreakLocationType.DebuggerStatement,
                "return" => CefNet.DevTools.Protocol.Debugger.BreakLocationType.Return,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Debugger.BreakLocationType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
